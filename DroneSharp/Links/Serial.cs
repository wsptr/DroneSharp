using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;

namespace DroneSharp.Links
{
    internal class Serial : ISerial
    {
        public string ConnectionString => $"SERIAL://{_Sp.PortName}:{_Sp.BaudRate}";

        public Stream BaseStream => _Sp == null ? null : _Sp.BaseStream;

        public int BaudRate { get => _Sp.BaudRate; set => _Sp.BaudRate = value; }

        public int BytesToRead => _Sp.BytesToRead;

        public int BytesToWrite => _Sp.BytesToWrite;

        public int DataBits { get => _Sp.DataBits; set => _Sp.DataBits = value; }
        public bool DtrEnable { get => _Sp.DtrEnable; set => _Sp.DtrEnable = value; }

        public bool IsOpen => _Sp == null ? false : _Sp.IsOpen;

        public string PortName { get => _Sp.PortName; set => _Sp.PortName = value; }
        public int ReadBufferSize { get => _Sp.ReadBufferSize; set => _Sp.ReadBufferSize = value; }
        public int ReadTimeout { get => _Sp.ReadTimeout; set => _Sp.ReadTimeout = value; }
        public bool RtsEnable { get => _Sp.RtsEnable; set => _Sp.RtsEnable = value; }
        public int WriteBufferSize { get => _Sp.WriteBufferSize; set => _Sp.WriteBufferSize = value; }
        public int WriteTimeout { get => _Sp.WriteTimeout; set => _Sp.WriteTimeout = value; }

        private SerialPort _Sp = new SerialPort();
        public void Open()
        {
            _Sp.Open();
        }

        public void Close()
        {
            _Sp.Close();
        }

        public void DiscardInBuffer()
        {
            _Sp.DiscardInBuffer();
        }

        public void Dispose()
        {
            _Sp.Dispose();
        }


        public int Read(byte[] buffer, int offset, int count)
        {
            return _Sp.Read(buffer, offset, count);
        }

        public int ReadByte()
        {
            return _Sp.ReadByte();
        }

        public int ReadChar()
        {
            return _Sp.ReadChar();
        }

        public string ReadExisting()
        {
            return _Sp.ReadExisting();
        }

        public string ReadLine()
        {
            return _Sp.ReadLine();
        }

        public void Write(string text)
        {
            _Sp.Write(text);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            _Sp.Write(buffer, offset, count);
        }

        public void WriteLine(string text)
        {
            _Sp.WriteLine(text);
        }

        MAVLink.MavlinkParse _Parse = new MAVLink.MavlinkParse();

        public event LinkBrokenEventHandler LinkBroken;

        public MAVLink.MAVLinkMessage ReadMessage()
        {
            MAVLink.MAVLinkMessage msg = null;
            try
            {
                msg = _Parse.ReadPacket(BaseStream);
            }
            catch (Exception ex)
            { }
            return msg;
        }

        public void WriteMessage(MAVLink.MAVLinkMessage message)
        {
            Write(message.buffer, 0, message.buffer.Length);
        }
    }
}
