using System.Net;

namespace KeyWhere.Core.Net
{
    public static class PacketParser
    {
        public static void Parse(SocketAddress socketAddress, byte[] data)
        {
            var packet = NetworkPacket.FromByteArray(data);
        }   
    }
}
