using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace DummyClient
{
    public interface Packetinterface
    {
        void encode();
        void decode(byte[] packet, ref int offset);

        Int64 type();
        MemoryStream getStream();
    }



    public class PacketData
    {
        protected MemoryStream packet_ = new MemoryStream();

        ~PacketData()
        {
            packet_ = null;
        }
    }
}
