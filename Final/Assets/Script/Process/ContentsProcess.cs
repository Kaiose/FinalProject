using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DummyClient
{
    public abstract class ContentsProcess
    {
        public bool defaultRun(Packetinterface packet)
        {
            PacketType type = (PacketType)packet.type();

            return false;
        }

        public abstract void run(Packetinterface packet);
    }
}
