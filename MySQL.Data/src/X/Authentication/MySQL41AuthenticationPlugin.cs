// Copyright (c) 2015, 2018, Oracle and/or its affiliates. All rights reserved.
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

using MySqlX.XDevAPI;
using System;
using System.Security.Cryptography;
using System.Text;

namespace MySqlX.Security
{
  /// <summary>
  /// Implementation of MySQL41 authentication type.
  /// </summary>
  internal class MySQL41AuthenticationPlugin
  {
    private MySqlXConnectionStringBuilder _settings;

    public MySQL41AuthenticationPlugin(MySqlXConnectionStringBuilder settings)
    {
      _settings = settings;
    }

    public byte[] Continue(byte[] salt)
    {
      var encoding = Encoding.GetEncoding("utf-8");

      byte[] userBytes = encoding.GetBytes(_settings.UserID);
      byte[] databaseBytes = encoding.GetBytes(_settings.Database);
      byte[] hashedPassword = new byte[0];
      byte[] hex = new byte[0];
      if (!string.IsNullOrWhiteSpace(_settings.Password))
      {
        hashedPassword = Get411Password(encoding.GetBytes(_settings.Password), salt);
        Array.Copy(hashedPassword, 1, hashedPassword, 0, hashedPassword.Length - 1);
        Array.Resize(ref hashedPassword, hashedPassword.Length - 1);
        //convert to hex value 
        hex = encoding.GetBytes(string.Format("*{0}", BitConverter.ToString(hashedPassword).Replace("-", string.Empty)));
      }

      // create response
      byte[] response = new byte[databaseBytes.Length + userBytes.Length + hex.Length + 2];
      databaseBytes.CopyTo(response, 0);
      var index = databaseBytes.Length;
      response[index++] = 0;
      userBytes.CopyTo(response, index);
      index += userBytes.Length;
      response[index++] = 0;
      hex.CopyTo(response, index);
      return response;
    }

    /// <summary>
    /// Returns a byte array containing the proper encryption of the 
    /// given password/seed according to the new 4.1.1 authentication scheme.
    /// </summary>
    /// <param name="password"></param>
    /// <param name="seedBytes"></param>
    /// <returns></returns>
    private byte[] Get411Password(byte[] password, byte[] seedBytes)
    {
      // if we have no password, then we just return 1 zero byte
      if (password.Length == 0) return new byte[1];
      //SHA1 sha = new SHA1CryptoServiceProvider();
      SHA1 sha = SHA1.Create();
      byte[] firstHash = sha.ComputeHash(password);
      byte[] secondHash = sha.ComputeHash(firstHash);

      byte[] input = new byte[seedBytes.Length + secondHash.Length];
      Array.Copy(seedBytes, 0, input, 0, seedBytes.Length);
      Array.Copy(secondHash, 0, input, seedBytes.Length, secondHash.Length);
      byte[] thirdHash = sha.ComputeHash(input);

      byte[] finalHash = new byte[thirdHash.Length + 1];
      finalHash[0] = 0x14;
      Array.Copy(thirdHash, 0, finalHash, 1, thirdHash.Length);

      for (int i = 1; i < finalHash.Length; i++)
        finalHash[i] = (byte)(finalHash[i] ^ firstHash[i - 1]);
      return finalHash;
    }
  }
}