using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace DroneSharp.Links
{
    internal class UdpSerial : ISerial
    {
        public string ConnectionString => $"UDP://{(IPEndPoint)_UdpClient.Client.LocalEndPoint}";

        private IPEndPoint _Remote = null;
        public Stream BaseStream
        {
            get
            {
                if (_Buffers.ContainsKey(_Remote))
                    return _Buffers[_Remote];
                else
                    return null;
            }
        }

        public int BaudRate { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public int BytesToRead
        {
            get
            {
                if (_Remote == null)
                    return 0;
                else
                    return (int)(_Buffers[_Remote].Length - _Buffers[_Remote].Position);
            }
        }

        public int BytesToWrite => 0;

        public int DataBits { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public bool DtrEnable { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public bool IsOpen => _UdpClient != null;

        public string PortName { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public int ReadBufferSize { get; set; }
        public int ReadTimeout { get; set; }
        public bool RtsEnable { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public int WriteBufferSize { get; set; }
        public int WriteTimeout { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        private int _Port = 14550;
        public int LocalPort
        {
            get
            {
                return _UdpClient == null ? _Port : ((IPEndPoint)_UdpClient.Client.LocalEndPoint).Port;
            }
            set
            {
                if (_UdpClient == null)
                {
                    _Port = value;
                }
            }
        }

        private IPAddress _LocalAddress = IPAddress.Any;
        public IPAddress LocalAddress
        {
            get
            {
                return _UdpClient == null ? _LocalAddress : ((IPEndPoint)_UdpClient.Client.LocalEndPoint).Address;
            }
            set
            {
                if (_UdpClient == null)
                {
                    _LocalAddress = value;
                }
            }
        }



        UdpClient _UdpClient = null;
        static Dictionary<IPEndPoint, MemoryStream> _Buffers = new Dictionary<IPEndPoint, MemoryStream>();
        static Dictionary<IPEndPoint, object> _BufferLocks = new Dictionary<IPEndPoint, object>();

        static Dictionary<IPEndPoint, bool> _BufferUsed = new Dictionary<IPEndPoint, bool>();
        static Dictionary<IPEndPoint, object> _BufferUsedLock = new Dictionary<IPEndPoint, object>();

        static Dictionary<IPEndPoint, UdpClient> _Instances = new Dictionary<IPEndPoint, UdpClient>();

        public UdpSerial()
        {

        }

        public void Open()
        {
            if (_UdpClient != null)
            {
                return;
            }

            IPEndPoint local = new IPEndPoint(LocalAddress, LocalPort);
            if (_Instances.ContainsKey(local) == false)
            {
                try
                {
                    _UdpClient = new UdpClient(new IPEndPoint(LocalAddress, LocalPort))
                    {
                        EnableBroadcast = true,
                    };
                    _UdpClient.Client.ReceiveBufferSize = ReadBufferSize;
                    _UdpClient.Client.SendBufferSize = WriteBufferSize;

                    _Instances.Add(local, _UdpClient);

                    _UdpClient.BeginReceive(UdpDataReceived, _UdpClient);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                _UdpClient = _Instances[local];
            }


        }

        public void Close()
        {
            _UdpClient?.Dispose();
            _UdpClient = null;
        }

        public bool HasStream
        {
            get
            {
                return _BufferUsed.Values.Where(v => v).Count() > 0;
            }
        }

        public bool GetStream()
        {
            foreach (IPEndPoint ipe in _BufferUsed.Keys)
            {
                if (_BufferUsed[ipe] == false)
                {
                    lock (_BufferUsedLock[ipe])
                    {
                        if (_BufferUsed[ipe] == false)
                        {
                            _BufferUsed[ipe] = true;
                            _Remote = ipe;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void DiscardInBuffer()
        {
            if (_Remote == null)
                return;

            lock (_BufferLocks[_Remote])
            {
                _Buffers[_Remote].Position = 0;
                _Buffers[_Remote].SetLength(0);
            }
        }

        public void Dispose()
        {
            if (_Remote == null)
                return;

            _UdpClient.Dispose();
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            if (_Remote == null) throw new InvalidOperationException();
            lock (_BufferLocks[_Remote])
            {
                int n = BaseStream.Read(buffer, offset, count);
                if (BaseStream.Position == BaseStream.Length)
                {
                    BaseStream.Position = 0;
                    BaseStream.SetLength(0);
                }
                return n;
            }
        }

        public int ReadByte()
        {
            if (_Remote == null) throw new InvalidOperationException();

            lock (_BufferLocks[_Remote])
            {
                int data = BaseStream.ReadByte();
                if (BaseStream.Position == BaseStream.Length)
                {
                    BaseStream.Position = 0;
                    BaseStream.SetLength(0);
                }
                return data;
            }
        }

        public int ReadChar()
        {
            return ReadByte();
        }

        public string ReadExisting()
        {
            if (_Remote == null) throw new InvalidOperationException();

            lock (_BufferLocks[_Remote])
            {
                byte[] bytes = new byte[BaseStream.Length];
                int count = BaseStream.Read(bytes, 0, bytes.Length);
                if (BaseStream.Position == BaseStream.Length)
                {
                    BaseStream.Position = 0;
                    BaseStream.SetLength(0);
                }
                return Encoding.ASCII.GetString(bytes);
            }
        }

        public string ReadLine()
        {
            throw new NotImplementedException();
        }

        public void Write(string text)
        {
            if (_Remote == null)
                return;

            var bytes = Encoding.ASCII.GetBytes(text);
            try
            {
                _UdpClient.BeginSend(bytes, bytes.Length, _Remote, UdpDataSent, _UdpClient);
            }
            catch (Exception ex)
            { }
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            if (offset == 0 && count == buffer.Length)
                _UdpClient.BeginSend(buffer, count, _Remote, UdpDataSent, _UdpClient);
            else
            {
                byte[] bytes = new byte[count];
                Array.Copy(buffer, offset, bytes, 0, count);
                _UdpClient.BeginSend(bytes, count, _Remote, UdpDataSent, _UdpClient);
            }
        }

        public void WriteLine(string text)
        {
            var bytes = Encoding.ASCII.GetBytes(text);
            Write(bytes, 0, bytes.Length);
        }

        private void UdpDataReceived(IAsyncResult ia)
        {
            UdpClient client = ia.AsyncState as UdpClient;
            try
            {
                IPEndPoint remote = null;
                byte[] bytes = client.EndReceive(ia, ref remote);
                MemoryStream ms;
                if (_Buffers.ContainsKey(remote) == false)
                {
                    ms = new MemoryStream();
                    _Buffers.Add(remote, ms);
                    _BufferLocks.Add(remote, new object());

                    _BufferUsed.Add(remote, false);
                    _BufferUsedLock.Add(remote, new object());
                }
                else
                    ms = _Buffers[remote];

                lock (_BufferLocks[remote])
                {
                    var pos = ms.Position;
                    ms.Seek(0, SeekOrigin.End);
                    ms.Write(bytes, 0, bytes.Length);
                    ms.Seek(pos, SeekOrigin.Begin);
                }
            }
            catch (Exception ex)
            {
                LinkBroken?.Invoke(this);
            }
            finally
            {
                if (client.Client != null)
                {
                    client.BeginReceive(UdpDataReceived, client);
                }
            }
        }

        private void UdpDataSent(IAsyncResult ia)
        {
            try
            {
                UdpClient client = ia.AsyncState as UdpClient;
                client.EndSend(ia);
            }
            catch (Exception ex)
            {

            }
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
