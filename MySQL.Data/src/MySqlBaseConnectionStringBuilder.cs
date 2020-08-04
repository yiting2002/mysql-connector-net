// Copyright (c) 2018, 2019, Oracle and/or its affiliates. All rights reserved.
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
using System.Data.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using MySql.Data.common;
using static MySql.Data.common.MySqlConnectionStringOption;
using System.Security.Authentication;

namespace MySql.Data.MySqlClient
{
  /// <summary>
  /// Abstract class that provides common functionality for connection options that apply for all protocols.
  /// </summary>
  public abstract class MySqlBaseConnectionStringBuilder : DbConnectionStringBuilder
  {
    /// <summary>
    /// Readonly field containing a collection of protocol shared connection options.
    /// </summary>
    internal static readonly MySqlConnectionStringOptionCollection Options = new MySqlConnectionStringOptionCollection();

    static MySqlBaseConnectionStringBuilder()
    {
      // Server options.
      Options.Add(new MySqlConnectionStringOption("server", "host,data source,datasource,address,addr,network address", typeof(string), "" /*"localhost"*/, false));
      Options.Add(new MySqlConnectionStringOption("database", "initial catalog", typeof(string), string.Empty, false));
      Options.Add(new MySqlConnectionStringOption("protocol", "connection protocol,connectionprotocol", typeof(MySqlConnectionProtocol), MySqlConnectionProtocol.Sockets, false,
        (SetterDelegate)((msb, sender, value) =>
        {
#if !NET452
         MySqlConnectionProtocol enumValue;
         if (Enum.TryParse<MySqlConnectionProtocol>(value.ToString(), true, out enumValue))
         {
           if (enumValue == MySqlConnectionProtocol.Memory || enumValue == MySqlConnectionProtocol.Pipe)
             throw new PlatformNotSupportedException(string.Format(Resources.OptionNotCurrentlySupported, $"Protocol={value}"));
         }
#endif
          msb.SetValue("protocol", value);
        }),
        (GetterDelegate)((msb, sender) => msb.ConnectionProtocol)));
      Options.Add(new MySqlConnectionStringOption("port", null, typeof(uint), (uint)3306, false));

      // Authentication options.
      Options.Add(new MySqlConnectionStringOption("user id", "uid,username,user name,user,userid", typeof(string), "", false));
      Options.Add(new MySqlConnectionStringOption("password", "pwd", typeof(string), "", false));

      // Other properties.
      Options.Add(new MySqlConnectionStringOption("keepalive", "keep alive", typeof(uint), (uint)0, false));

      // Language and charset options.
      Options.Add(new MySqlConnectionStringOption("characterset", "character set,charset", typeof(string), "", false));
    }

    /// <summary>
    /// Gets or sets a flag indicating if the object has access to procedures.
    /// </summary>
    internal bool HasProcAccess { get; set; }

    /// <summary>
    /// Gets or sets a dictionary representing key-value pairs for each connection option.
    /// </summary>
    internal Dictionary<string, object> values { get; set; }
    #region Server Properties

    /// <summary>
    /// Gets or sets the name of the server.
    /// </summary>
    /// <value>The server.</value>
    [Category("Connection")]
    [Description("Server to connect to")]
    [RefreshProperties(RefreshProperties.All)]
    public string Server
    {
      get { return this["server"] as string; }
      set { SetValue("server", value); }
    }

    /// <summary>
    /// Gets or sets the name of the database for the initial connection.
    /// </summary>
    [Category("Connection")]
    [Description("Database to use initially")]
    [RefreshProperties(RefreshProperties.All)]
    public string Database
    {
      get { return values["database"] as string; }
      set { SetValue("database", value); }
    }

    /// <summary>
    /// Gets or sets the protocol that should be used for communicating
    /// with MySQL.
    /// </summary>
    [Category("Connection")]
    [DisplayName("Connection Protocol")]
    [Description("Protocol to use for connection to MySQL")]
    [RefreshProperties(RefreshProperties.All)]
    public MySqlConnectionProtocol ConnectionProtocol
    {
      get { return (MySqlConnectionProtocol)values["protocol"]; }
      set { SetValue("protocol", value); }
    }

    /// <summary>
    /// Gets or sets the port number that is used when the socket
    /// protocol is being used.
    /// </summary>
    [Category("Connection")]
    [Description("Port to use for TCP/IP connections")]
    [RefreshProperties(RefreshProperties.All)]
    public uint Port
    {
      get { return (uint)values["port"]; }
      set { SetValue("port", value); }
    }

    #endregion

    #region Authentication Properties

    /// <summary>
    /// Gets or sets the user ID that should be used to connect with.
    /// </summary>
    [Category("Security")]
    [DisplayName("User ID")]
    [Description("Indicates the user ID to be used when connecting to the data source.")]
    [RefreshProperties(RefreshProperties.All)]
    public string UserID
    {
      get { return (string)values["user id"]; }
      set { SetValue("user id", value); }
    }

    /// <summary>
    /// Gets or sets the password that should be used to make a connection.
    /// </summary>
    [Category("Security")]
    [Description("Indicates the password to be used when connecting to the data source.")]
    [RefreshProperties(RefreshProperties.All)]
    [PasswordPropertyText(true)]
    public string Password
    {
      get { return (string)values["password"]; }
      set { SetValue("password", value); }
    }

    #endregion

    #region Other Properties

    /// <summary>
    /// Gets or sets the idle connection time(seconds) for TCP connections.
    /// </summary>
    [DisplayName("Keep Alive")]
    [Description("For TCP connections, the idle connection time (in seconds) before the first keepalive packet is sent." +
        "A value of 0 indicates that keepalive is not used.")]
    [DefaultValue(0)]
    public uint Keepalive
    {
      get { return (uint)values["keepalive"]; }
      set { SetValue("keepalive", value); }
    }

    #endregion

    #region Language and Character Set Properties

    /// <summary>
    /// Gets or sets the character set that should be used for sending queries to the server.
    /// </summary>
    [DisplayName("Character Set")]
    [Category("Advanced")]
    [Description("Character set this connection should use.")]
    [RefreshProperties(RefreshProperties.All)]
    [DefaultValue("")]
    public string CharacterSet
    {
      get { return (string)values["characterset"]; }
      set { SetValue("characterset", value); }
    }

    #endregion

    /// <summary>
    /// Analyzes the connection string for potential duplicated or invalid connection options.
    /// </summary>
    /// <param name="connectionString">Connection string.</param>
    internal void AnalyzeConnectionString(string connectionString)
    {
      string[] queries = connectionString.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
      var usedSslOptions = new List<string>();

      foreach (string query in queries)
      {
        string[] keyValue = query.Split('=');
        if (keyValue.Length % 2 != 0)
          continue;

        var keyword = keyValue[0].ToLowerInvariant().Trim();
        var value = query.Contains(",") ? query.Replace(keyword, "") : keyValue[1].ToLowerInvariant();
        MySqlConnectionStringOption option = Options.Options.Where(o => o.Keyword == keyword || (o.Synonyms != null && o.Synonyms.Contains(keyword))).FirstOrDefault();

        if (option == null
          || (option.Keyword != "server"))
          continue;

        if (usedSslOptions.Contains(option.Keyword))
          throw new ArgumentException(string.Format(Resources.DuplicatedConnectionOption, keyword));

          usedSslOptions.Add(option.Keyword);
      }
    }

    public string GetConnectionString(bool includePass)
    {
      if (includePass) return ConnectionString;

      var conn = new StringBuilder();
      string delimiter = "";
      foreach (string key in this.Keys)
      {
        if (string.Compare(key, "password", StringComparison.OrdinalIgnoreCase) == 0 ||
            string.Compare(key, "pwd", StringComparison.OrdinalIgnoreCase) == 0) continue;
        conn.AppendFormat(CultureInfo.CurrentCulture, "{0}{1}={2}",
            delimiter, key, this[key]);
        delimiter = ";";
      }

      return conn.ToString();
    }

    internal abstract MySqlConnectionStringOption GetOption(string key);
    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    internal void SetValue(string keyword, object value, [CallerMemberName] string callerName = "")
    {
      MySqlConnectionStringOption option = GetOption(keyword);
      if (callerName != ".cctor" && option.IsCustomized)
        this[keyword] = value;
      else
        SetInternalValue(keyword, value);
    }

    internal abstract void SetInternalValue(string keyword, object value);
  }
}
