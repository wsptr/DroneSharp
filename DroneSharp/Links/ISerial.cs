using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DroneSharp.Links
{
    public delegate void LinkBrokenEventHandler(ISerial iSerial);
    public interface ISerial : IDisposable
    {
        event LinkBrokenEventHandler LinkBroken;
        string ConnectionString { get; }
        Stream BaseStream { get; }

        int BaudRate { get; set; }

        int BytesToRead { get; }

        int BytesToWrite { get; }

        int DataBits { get; set; }

        bool DtrEnable { get; set; }

        bool IsOpen { get; }

        string PortName { get; set; }

        int ReadBufferSize { get; set; }

        int ReadTimeout { get; set; }

        bool RtsEnable { get; set; }

        int WriteBufferSize { get; set; }

        int WriteTimeout { get; set; }

        void Close();

        void DiscardInBuffer();

        void Open();

        int Read(byte[] buffer, int offset, int count);

        int ReadByte();

        int ReadChar();

        string ReadExisting();

        string ReadLine();

        void Write(string text);

        void Write(byte[] buffer, int offset, int count);

        void WriteLine(string text);
        MAVLink.MAVLinkMessage ReadMessage();
        void WriteMessage(MAVLink.MAVLinkMessage message);
    }
}
