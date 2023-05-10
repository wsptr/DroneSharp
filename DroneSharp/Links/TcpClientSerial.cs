using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace DroneSharp.Links
{
    internal class TcpClientSerial : ISerial
    {
        public string ConnectionString => $"TCP://{RemoteIP}:{RemotePort}";
        NetworkStream _Ns = null;
        public Stream BaseStream => _Ns;

        public int BaudRate { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public int BytesToRead => _Ns == null ? 0 : (int)_Ns.Length;

        public int BytesToWrite => 0;

        public int DataBits { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public bool DtrEnable { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public bool IsOpen => _TcpClient != null && _TcpClient.Connected;

        public string PortName { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public int ReadBufferSize { get; set; }
        public int ReadTimeout { get; set; }
        public bool RtsEnable { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public int WriteBufferSize { get; set; }
        public int WriteTimeout { get; set; }

        public IPAddress RemoteIP { get; set; } = IPAddress.Any;
        public int RemotePort { get; set; } = 5760;

        TcpClient _TcpClient = new TcpClient();

        public TcpClientSerial()
        { }

        public void Open()
        {
            if (_TcpClient.Connected)
            {
                throw new InvalidOperationException("TCP 连接已打开");
            }

            _TcpClient.Client.ReceiveBufferSize = ReadBufferSize;
            _TcpClient.Client.SendBufferSize = WriteBufferSize;
            _TcpClient.Client.ReceiveTimeout = ReadTimeout;
            _TcpClient.Client.SendTimeout = WriteTimeout;
            _TcpClient.Connect(RemoteIP, RemotePort);
            if (_TcpClient.Connected)
                _Ns = _TcpClient.GetStream();
        }

        public void Close()
        {
            if (_TcpClient == null)
                return;

            _Ns = null;
            _TcpClient?.Close();
            _TcpClient?.Dispose();
        }

        public void DiscardInBuffer()
        {
            int n = _TcpClient.Available;
            if (n == 0) return;
            byte[] buffer = new byte[n];
            _Ns.Read(buffer, 0, n);
        }

        public void Dispose()
        {
            _TcpClient?.Dispose();
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return _Ns.Read(buffer, offset, count);
        }

        public int ReadByte()
        {
            return _Ns.ReadByte();
        }

        public int ReadChar()
        {
            return _Ns.ReadByte();
        }

        public string ReadExisting()
        {
            int n = (int)_Ns.Length;
            if (n == 0) return string.Empty;
            byte[] buffer = new byte[n];
            _Ns.Read(buffer, 0, n);
            return Encoding.ASCII.GetString(buffer);
        }

        public string ReadLine()
        {
            throw new NotSupportedException();
        }

        public void Write(string text)
        {
            var bytes = Encoding.ASCII.GetBytes(text);
            _Ns.Write(bytes, 0, bytes.Length);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            _Ns.Write(buffer, offset, count);
        }

        public void WriteLine(string text)
        {
            Write(text);
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
