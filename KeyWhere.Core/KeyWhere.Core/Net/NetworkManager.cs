using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace KeyWhere.Core.Net
{
    public class NetworkManager : IDisposable
    {
        private static NetworkManager networkManager;
        internal static NetworkManager Instance
        {
            get
            {
                if (networkManager == null)
                    networkManager = new NetworkManager();
                return networkManager;
            }
        }

        private UdpClient Client;
        private Thread thread;
        private bool running = false;

        private int port;

        private NetworkManager()
        {
            Client = new UdpClient() { EnableBroadcast = true };
            thread = new Thread(Listen) { IsBackground = true };
        }

        public void Start()
        {
            running = true;
            thread.Start();
        }

        private void Listen()
        {
            while (running)
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Any, port);
                byte[] data = Client.Receive(ref ip);
                PacketParser.Parse(ip.Serialize(), data);
            }
        }

        public void Dispose()
        {
            running = false;
            thread.Interrupt();
            Client.Close();
        }
    }
}
