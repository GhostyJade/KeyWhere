using System.Collections.Generic;
using System.IO;

namespace KeyWhere.Core.Net
{
    public class NetworkPacket
    {
        private readonly Dictionary<string, IPacketBase> Data = new(); 

        public static byte[] ToByteArray(NetworkPacket packet)
        {
            using MemoryStream stream = new MemoryStream();
            using BinaryWriter bw = new BinaryWriter(stream);
            foreach (var p in packet.Data)
                bw.Write(p.Value.GetBytes());
            return stream.ToArray();
        }

        public static NetworkPacket FromByteArray(byte[] data)
        {
            using MemoryStream stream = new MemoryStream();
            using BinaryReader br = new BinaryReader(stream);
            
            return null;
        }
    }
}
