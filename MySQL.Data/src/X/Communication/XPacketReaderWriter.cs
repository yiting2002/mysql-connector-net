// Copyright © 2015, 2019, Oracle and/or its affiliates. All rights reserved.
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

using Google.Protobuf;
using Mysqlx;
using Mysqlx.Connection;
using System;
using System.IO;

namespace MySqlX.Communication
{
  internal class XPacketReaderWriter
  {
    private Stream _stream;

    /// <summary>
    /// Constructor that sets the stream used to read or write data.
    /// </summary>
    /// <param name="stream">The stream used to read or write data.</param>
    public XPacketReaderWriter(Stream stream)
    {
      _stream = stream;
    }

    /// <summary>
    /// Writes X Protocol frames to the X Plugin.
    /// </summary>
    /// <param name="id">The integer representation of the client message identifier used for the message.</param>
    /// <param name="message">The message to include in the X Protocol frame.</param>
    public void Write(int id, IMessage message)
    {
      var messageSize = message.CalculateSize();
      {
        _stream.Write(BitConverter.GetBytes(messageSize + 1), 0, 4);
        _stream.WriteByte((byte)id);
        if (messageSize > 0)
        {
          message.WriteTo(_stream);
        }
      }

      _stream.Flush();
    }

    /// <summary>
    /// Writes X Protocol frames to the X Plugin.
    /// </summary>
    /// <param name="id">The client message identifier used for the message.</param>
    /// <param name="message">The message to include in the X Protocol frame.</param>
    public void Write(ClientMessageId id, IMessage message)
    {
      Write((int)id, message);
    }


    /// <summary>
    /// Reads X Protocol frames incoming from the X Plugin.
    /// </summary>
    /// <returns>A <see cref="CommunicationPacket"/> instance representing the X Protocol frame that was read.</returns>
    public CommunicationPacket Read()
    {
      byte[] header = new byte[5];
      ReadFully(header, 0, 5);
      int length = BitConverter.ToInt32(header, 0);
      byte[] data = new byte[length - 1];
      ReadFully(data, 0, length - 1);

      return new CommunicationPacket(header[4], length - 1, data);
    }

    void ReadFully(byte[] buffer, int offset, int count)
    {
      int numRead = 0;
      int numToRead = count;
      while (numToRead > 0)
      {
        int read = _stream.Read(buffer, offset + numRead, numToRead);
        if (read == 0)
        {
          throw new EndOfStreamException();
        }
        numRead += read;
        numToRead -= read;
      }
    }
  }
}
