using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DummyClient
{
    public class GameContentsProcess : ContentsProcess
    {
        GamePacketProcess gamePacketProcess = null;

        public GameContentsProcess()
        {
            gamePacketProcess = new GamePacketProcess();
        }


        public override void run(Packetinterface packet)
        {
            PacketType type = (PacketType)packet.type();

            Debug.Log("받은 게임 패킷 : " + type);

            switch (type)
            {

                case PacketType.E_S_ANS_GAME_EXIT:
                    gamePacketProcess.S_ANS_EXIT(packet);
                    return;
            }
            if (base.defaultRun(packet) == false)
            {
#if DEBUG
                Debug.Log("잘못된 패킷이 수신되었습니다 : ");

#endif
            }

        }


    }
}
