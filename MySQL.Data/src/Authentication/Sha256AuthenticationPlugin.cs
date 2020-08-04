// Copyright (c) 2013, 2019, Oracle and/or its affiliates. All rights reserved.
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
using System.Text;
using System.Security.Cryptography;

namespace MySql.Data.MySqlClient.Authentication
{
  /// <summary>
  /// The implementation of the sha256_password authentication plugin.
  /// </summary>
  internal class Sha256AuthenticationPlugin : MySqlAuthenticationPlugin
  {
    /// <summary>
    /// The byte array representation of the public key provided by the server.
    /// </summary>
    protected byte[] rawPubkey;

    public override string PluginName => "sha256_password";

    protected override byte[] MoreData(byte[] data)
    {
      rawPubkey = data;
      byte[] buffer = GetNonLengthEncodedPassword();
      return buffer;
    }

    public override object GetPassword()
    {
      {
        if (Settings.Password.Length == 0) return new byte[1];
        // send RSA encrypted, since the channel is not protected
        else if (rawPubkey == null) return new byte[] { 0x01 };
        else if (!Settings.AllowPublicKeyRetrieval)
          throw new MySqlException(Resources.RSAPublicKeyRetrievalNotEnabled);
        else
        {
          byte[] bytes = GetRsaPassword(Settings.Password, AuthenticationData, rawPubkey);
          if (bytes != null && bytes.Length == 1 && bytes[0] == 0) return null;
          return bytes;
        }
      }
    }

    private byte[] GetNonLengthEncodedPassword()
    {
      // Required for AuthChange requests.
      return GetPassword() as byte[];
    }

    private byte[] GetRsaPassword(string password, byte[] seedBytes, byte[] rawPublicKey)
    {
      if (password.Length == 0) return new byte[1];
      // Obfuscate the plain text password with the session scramble
      byte[] obfuscated = GetXor(Encoding.Default.GetBytes(password), seedBytes);
      // Encrypt the password and send it to the server
      RSACryptoServiceProvider rsa = MySqlPemReader.ConvertPemToRSAProvider(rawPublicKey);
      if (rsa == null) throw new MySqlException(Resources.UnableToReadRSAKey);
      return rsa.Encrypt(obfuscated, true);
    }

    /// <summary>
    /// Applies XOR to the byte arrays provided as input.
    /// </summary>
    /// <returns>A byte array that contains the results of the XOR operation.</returns>
    protected byte[] GetXor( byte[] src, byte[] pattern )
    {
      byte[] src2 = new byte[src.Length + 1];
      Array.Copy(src, 0, src2, 0, src.Length);
      src2[src.Length] = 0;
      byte[] result = new byte[src2.Length];
      for (int i = 0; i < src2.Length; i++)
      {
        result[ i ] = ( byte )( src2[ i ] ^ ( pattern[ i % pattern.Length ] ));
      }
      return result;
    }
  }
}
