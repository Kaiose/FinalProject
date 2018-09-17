using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
namespace DummyClient
{
    class LogInContentsProcess : ContentsProcess
    {
        LoginPacketProcess LoginPacketProcess = null;
        

        public LogInContentsProcess()
        {
            LoginPacketProcess = new LoginPacketProcess();
        }


        // 로그인 과 채팅은 상관없는데 게임은함수포인터맵으로 바꾸는게 좋을듯함

        public override void run(Packetinterface packet)
        {
            PacketType type = (PacketType)packet.type();

            Debug.Log("받은 로그인 패킷" + type);


            switch (type)
            {
                case PacketType.E_S_ANS_ID_PW_FAIL:
                    LoginPacketProcess.S_ANS_ID_PW_FAIL(packet);
                    return;
                case PacketType.E_S_ANS_ID_PW_SUCCESS_CHATTING:
                    LoginPacketProcess.S_ANS_ID_PW_FAIL(packet);
                    return;
                case PacketType.E_S_ANS_ID_PW_SUCCESS_GAME:
                    LoginPacketProcess.S_ANS_ID_PW_SUCCESS_GAME(packet);
                    return;
                case PacketType.E_S_ANS_EXIT:
                    return;
            }

            if(base.defaultRun(packet)== false)
            {
# if DEBUG
                Debug.Log("잘못된 패킷이 수신되었습니다. : ");
                Debug.Log(type);
#endif
            }
        }
    }
}
