﻿// Copyright (c) 2019, Oracle and/or its affiliates. All rights reserved.
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License, version 2.0, as
// published by the Free Software Foundation.
//
// This program is also distributed with certain software (including
// but not limited to OpenSSL) that is licensed under separate terms,
// as designated in a particular file or component or in included license
// documentation.  The authors of MySQL hereby grant you an
// additional permission to link the program and your derivative works
// with the separately licensed software that they have included with
// MySQL.
//
// Without limiting anything contained in the foregoing, this file,
// which is part of MySQL Connector/NET, is also subject to the
// Universal FOSS Exception, version 1.0, a copy of which can be found at
// http://oss.oracle.com/licenses/universal-foss-exception.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License, version 2.0, for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql.Data.common;
using System.Collections.Generic;

namespace MySqlX.XDevAPI
{
  /// <summary>
  /// Enables the creation of connection strings by exposing the connection options as properties.
  /// Contains connection options specific to the X protocol.
  /// </summary>
  public sealed class MySqlXConnectionStringBuilder : MySqlBaseConnectionStringBuilder
  {
    static MySqlXConnectionStringBuilder()
    {
      // Add options shared between classic and X protocols from base class.
      Options = MySqlBaseConnectionStringBuilder.Options.Clone();

      // Server options.
      Options.Add(new MySqlConnectionStringOption("connect-timeout", "connecttimeout", typeof(uint), (uint)10000, false,
        delegate (MySqlXConnectionStringBuilder msb, MySqlConnectionStringOption sender, object Value)
        {
          sender.ValidateValue(ref Value, sender.Keyword);
          uint value = (uint)Convert.ChangeType(Value, sender.BaseType);
          // Timeout in milliseconds should not exceed maximum for 32 bit
          // signed integer (~24 days). We truncate the value if it exceeds
          // maximum (MySqlCommand.CommandTimeout uses the same technique)
          uint timeout = Math.Min(value, Int32.MaxValue);
          msb.SetValue("connect-timeout", timeout);

        },
        (msb, sender) => (uint)msb.values["connect-timeout"]
        ));

      // Authentication options.
      Options.Add(new MySqlConnectionStringOption("auth", null, typeof(MySqlAuthenticationMode), MySqlAuthenticationMode.Default, false,
        (msb, sender, value) => { msb.SetValue("auth", value); }, (msb, sender) => msb.Auth));
    }

    /// <summary>
    /// Main constructor.
    /// </summary>
    public MySqlXConnectionStringBuilder()
    {
      values = new Dictionary<string, object>();
      HasProcAccess = true;

      // Populate initial values.
      lock (this)
      {
        foreach (MySqlConnectionStringOption option in Options.Options)
        {
          values[option.Keyword] = option.DefaultValue;
        }
      }
    }

    /// <summary>
    /// Constructor accepting a connection string.
    /// </summary>
    /// <param name="connectionString">The connection string.</param>
    public MySqlXConnectionStringBuilder(string connectionString) : this()
    {
      AnalyzeConnectionString(connectionString);
      lock (this)
      {
        ConnectionString = connectionString;
      }
    }

    /// <summary>
    /// Readonly field containing a collection of classic protocol and protocol shared connection options.
    /// </summary>
    internal new static readonly MySqlConnectionStringOptionCollection Options;

    #region Server Properties

    /// <summary>
    /// Gets or sets the connection timeout.
    /// </summary>
    [Category("Connection")]
    [DisplayName("Connect Timeout")]
    [Description("The length of time (in milliseconds) to wait for a connection " +
                 "to the server before terminating the attempt and generating an error.")]
    [RefreshProperties(RefreshProperties.All)]
    public uint ConnectTimeout
    {
      get { return (uint)values["connect-timeout"]; }

      set
      {
        // Timeout in milliseconds should not exceed maximum for 32 bit
        // signed integer (~24 days). We truncate the value if it exceeds
        // maximum (MySqlCommand.CommandTimeout uses the same technique
        uint timeout = Math.Min(value, Int32.MaxValue);
        SetValue("connect-timeout", timeout);
      }
    }

    #endregion

    #region Authentication Properties

    [Category("Authentication")]
    [DisplayName("Auth")]
    [Description("Authentication mechanism")]
    [DefaultValue(MySqlAuthenticationMode.Default)]
    public MySqlAuthenticationMode Auth
    {
      get { return (MySqlAuthenticationMode)values["auth"]; }
      set { SetValue("auth", value); }
    }

    #endregion

    /// <summary>
    /// Gets or sets a connection option.
    /// </summary>
    /// <param name="keyword">The keyword that identifies the connection option to modify.</param>
    public override object this[string keyword]
    {
      get
      {
        MySqlConnectionStringOption opt = GetOption(keyword);
        if (opt.XGetter != null)
          return opt.XGetter(this, opt);
        else if (opt.Getter != null)
          return opt.Getter(this, opt);
        else
          throw new ArgumentException(Resources.KeywordNotSupported, keyword);
      }
      set
      {
        MySqlConnectionStringOption opt = GetOption(keyword);
        if (opt.XSetter != null)
          opt.XSetter(this, opt, value);
        else if (opt.Setter != null)
          opt.Setter(this, opt, value);
        else
          throw new ArgumentException(Resources.KeywordNotSupported, keyword);
      }
    }

    public override void Clear()
    {
      base.Clear();
      lock (this)
      {
        foreach (var option in Options.Options)
          if (option.DefaultValue != null)
            values[option.Keyword] = option.DefaultValue;
          else
            values[option.Keyword] = null;
      }
    }

    public override bool ContainsKey(string keyword)
    {
      MySqlConnectionStringOption option = Options.Get(keyword);
      return option != null;
    }

    public override bool Equals(object obj)
    {
      var other = obj as MySqlXConnectionStringBuilder;
      if (obj == null)
        return false;

      if (this.values.Count != other.values.Count) return false;

      foreach (KeyValuePair<string, object> kvp in this.values)
      {
        if (other.values.ContainsKey(kvp.Key))
        {
          object v = other.values[kvp.Key];
          if (v == null && kvp.Value != null) return false;
          if (kvp.Value == null && v != null) return false;
          if (kvp.Value == null && v == null) return true;
          if (!v.Equals(kvp.Value)) return false;
        }
        else
        {
          return false;
        }
      }

      return true;
    }

    internal override MySqlConnectionStringOption GetOption(string key)
    {
      MySqlConnectionStringOption option = Options.Get(key);
      if (option == null)
        throw new ArgumentException(Resources.KeywordNotSupported, key);
      else
        return option;
    }

    internal override void SetInternalValue(string keyword, object value)
    {
      MySqlConnectionStringOption option = GetOption(keyword);
      option.ValidateValue(ref value, keyword, true);

      // remove all related keywords
      option.Clean(this);

      if (value != null)
      {
        lock (this)
        {
          // set value for the given keyword
          values[option.Keyword] = value;
          base[keyword] = value;
        }
      }
    }

    public override bool Remove(string keyword)
    {
      bool removed = false;
      lock (this) { removed = base.Remove(keyword); }
      if (!removed) return false;
      MySqlConnectionStringOption option = GetOption(keyword);
      lock (this)
      {
        values[option.Keyword] = option.DefaultValue;
      }
      return true;
    }
  }
}
