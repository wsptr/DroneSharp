using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DroneSharp.Links
{
    public static class Link
    {
        public static string LastError = string.Empty;

        static Dictionary<string, ISerial> _Links = new Dictionary<string, ISerial>();

        public static ISerial Create(string connectionString)
        {
            if (_Links.ContainsKey(connectionString))
                return _Links[connectionString];

            ISerial link = null;

            string conn = connectionString.ToUpper().Trim();
            var parts = conn.Split(':');
            if (parts.Length != 3)
            {
                LastError = "连接字符串错误";
                return null;
            }

            if (parts[0] == "SERIAL")
            {
                Serial serial = new Serial();
                string port = parts[1].Substring(2);
                int baud = 0;
                if (int.TryParse(parts[2], out baud) == false)
                {
                    LastError = "串口波特率设置错误";
                    return null;
                }

                serial.PortName = port;
                serial.BaudRate = baud;
                link = serial;
            }
            else if (parts[0] == "UDP")
            {
                string ipStr = parts[1].Substring(2);
                IPAddress ip = null;
                if (IPAddress.TryParse(ipStr, out ip) == false)
                {
                    LastError = "IP 地址格式不正确";
                    return null;
                }

                int port = 0;
                if (int.TryParse(parts[2], out port) == false)
                {
                    LastError = "端口号不正确";
                    return null;
                }

                UdpSerial udp = new UdpSerial();
                udp.LocalPort = port;
                udp.LocalAddress = ip;
                link = udp;
            }
            else if (parts[0] == "TCP")
            {
                string ipStr = parts[1].Substring(2);
                IPAddress ip = null;
                if (IPAddress.TryParse(ipStr, out ip) == false)
                {
                    LastError = "IP 地址格式不正确";
                    return null;
                }

                int port = 0;
                if (int.TryParse(parts[2], out port) == false)
                {
                    LastError = "端口号不正确";
                    return null;
                }

                TcpClientSerial tcp = new TcpClientSerial();
                tcp.RemoteIP = ip;
                tcp.RemotePort = port;
                link = tcp;
            }
            else
            {
                LastError = string.Empty;
                return null;
            }

            return link;
        }
    }
}
