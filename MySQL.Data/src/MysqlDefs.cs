// Copyright (c) 2004, 2019, Oracle and/or its affiliates. All rights reserved.
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
using System.Globalization;

namespace MySql.Data.MySqlClient
{

  /// <summary>
  /// Allows the user to specify the type of connection that should
  /// be used.
  /// </summary>
  public enum MySqlConnectionProtocol
  {
    /// <summary>
    /// TCP/IP style connection. Works everywhere.
    /// </summary>
    Sockets = 1,
    /// <summary>
    /// TCP/IP style connection. Works everywhere.
    /// </summary>
    Socket = 1,
    /// <summary>
    /// TCP/IP style connection. Works everywhere.
    /// </summary>
    Tcp = 1,
    /// <summary>
    /// Named pipe connection. Works only on Windows systems.
    /// </summary>
    Pipe = 2,
    /// <summary>
    /// Named pipe connection. Works only on Windows systems.
    /// </summary>
    NamedPipe = 2,
    /// <summary>
    /// Unix domain socket connection. Works only with Unix systems.
    /// </summary>
    UnixSocket = 3,
    /// <summary>
    /// Unix domain socket connection. Works only with Unix systems.
    /// </summary>
    Unix = 3,
    /// <summary>
    /// Shared memory connection. Currently works only with Windows systems.
    /// </summary>
    SharedMemory = 4,
    /// <summary>
    /// Shared memory connection. Currently works only with Windows systems.
    /// </summary>
    Memory = 4
  }

  /// <summary>
  /// Specifies the authentication mechanism that should be used.
  /// </summary>
  public enum MySqlAuthenticationMode
  {
    /// <summary>
    /// If SSL is enabled or Unix sockets are being used, sets PLAIN as the authentication mechanism;
    /// otherwise, it tries to use MYSQL41 and then SHA256_MEMORY.
    /// </summary>
    Default = 0,
    AUTO = 0,
    /// <summary>
    /// Authenticate using PLAIN.
    /// </summary>
    PLAIN = 1,
    /// <summary>
    /// Authenticate using MYSQL41.
    /// </summary>
    MYSQL41 = 2,
    /// <summary>
    /// Authenticate using EXTERNAL.
    /// </summary>
    EXTERNAL = 3,
    /// <summary>
    /// Authenticate using SHA256_MEMORY.
    /// </summary>
    SHA256_MEMORY = 4
  }

  /// <summary>
  /// Defines waiting options that may be used with row locking options.
  /// </summary>
  public enum LockContention
  {
    /// <summary>
    /// Waits until the blocking transaction releases the row lock.
    /// </summary>
    Default = 0,
    /// <summary>
    /// Never waits to acquire a row lock. The query executes immediately, 
    /// failing with an error if a requested row is locked.
    /// </summary>
    NoWait = 1,
    /// <summary>
    /// Never waits to acquire a row lock. The query executes immediately, 
    /// removing locked rows from the result set.
    /// </summary>
    SkipLocked = 2
  }

  internal class MySqlConnectAttrs
  {
    static string _version;
    static string _os;
    static string _platform;
    static string _osName;
    static string _framework;

    static MySqlConnectAttrs()
    {
      InitVersion();
      InitOS();
      InitPlatform();
      InitOSName();
      InitFramework();
    }

    [DisplayName("_client_name")]
    public string ClientName => "mysql-connector-net";

    [DisplayName("_client_licence")]
    public string ClientLicence
    {
      get
      {
#if COMMERCIAL
        return "Commercial";
#endif
        return "GPL-2.0";
      }
    }

    [DisplayName("_pid")]
    public string PID
    {
      get
      {
        string pid = string.Empty;
        try
        {
          pid = System.Diagnostics.Process.GetCurrentProcess().Id.ToString(CultureInfo.InvariantCulture);
        }
        catch (Exception ex)
        {
          System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        return pid;
      }
    }

    [DisplayName("_client_version")]
    public string ClientVersion
    {
      get { return _version; }
    }

    [DisplayName("_os")]
    public string OS
    {
      get { return _os; }
    }

    [DisplayName("_thread")]
    public string Thread
    {
      get
      {
        string thread = string.Empty;
        try
        {
          thread = System.Diagnostics.Process.GetCurrentProcess().Threads[0].Id.ToString(CultureInfo.InvariantCulture);
        }
        catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex.ToString()); }

        return thread;
      }
    }

    [DisplayName("_platform")]
    public string Platform
    {
      get { return _platform; }
    }

    [DisplayName("_os")]
    public string OSName
    {
      get { return _osName; }
    }

    [DisplayName("_framework")]
    public string Framework
    {
      get { return _framework; }
    }

    private static void InitVersion()
    {
      _version = "8.0.19";
    }

    private static void InitOS()
    {
      _os = string.Empty;
      try
      {
        _os = Environment.OSVersion.Platform.ToString();
        if (_os == "Win32NT")
        {
          _os = "Win";
          _os += Is64BitOS() ? "64" : "32";
        }
      }
      catch (Exception ex)
      {
        System.Diagnostics.Debug.WriteLine(ex.ToString());
      }
    }

    private static void InitPlatform()
    {
      _platform = Is64BitOS() ? "x86_64" : "x86_32";
    }

    private static bool Is64BitOS()
    {
      return Environment.Is64BitOperatingSystem;
    }

    private static void InitOSName()
    {
      _osName = _os;

      var osInfo = Environment.OSVersion;
      var major = osInfo.Version.Major;
      var minor = osInfo.Version.Minor;

      if (osInfo.Platform.ToString().StartsWith("Win"))
      {
        switch (major)
        {
          case 5:
            _osName = "Windows-XP-" + major + "." + minor;
            break;
          case 6:
            switch (minor)
            {
              case 0:
                _osName = "Windows-2008-" + major + "." + minor;
                break;
              case 1:
                _osName = "Windows-7-" + major + "." + minor;
                break;
              case 2:
                _osName = "Windows-8-" + major + "." + minor;
                break;
              case 3:
                _osName = "Windows-8.1-" + major + "." + minor;
                break;
            }
            break;
          case 10:
            _osName = "Windows-10-" + major + "." + minor;
            break;
          default:
            _osName = "Windows";
            break;
        }
      }
      else
        _osName = _os + "-" + major + "." + minor;
    }

    private static void InitFramework()
    {
      _framework = ".NETCoreApp,Version=v2.1";
    }
  }
}
