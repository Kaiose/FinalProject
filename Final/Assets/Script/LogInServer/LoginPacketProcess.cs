using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.SceneManagement;
namespace DummyClient
{

    class LoginPacketProcess : PacketProcess
    {

        public void S_ANS_ID_PW_FAIL(Packetinterface rowPacket)
        {
            Debug.Log("로그인 실패");
        }

        public void S_ANS_ID_PW_SUCCESS_CHATTING(Packetinterface rowPacket)
        {
            
        }

        public void S_ANS_ID_PW_SUCCESS_GAME(Packetinterface rowPacket) {

            PK_S_ANS_ID_PW_SUCCESS_GAME packet = (PK_S_ANS_ID_PW_SUCCESS_GAME)rowPacket;

            GameNetWork.getInstance.name_ = packet.name_;

            GameNetWork.getInstance.Open(packet.ip_, packet.port_);
            PK_C_REQ_REGIST_GAMING_CHARACTER_INFO retPacket = new PK_C_REQ_REGIST_GAMING_CHARACTER_INFO();

            retPacket.name_ = packet.name_;

            GameNetWork.getInstance.sendPacket(retPacket);

            SceneChange.getInstance.ChangeScene("RoomScene");
        }

        public override void S_ANS_EXIT(Packetinterface rowPacket)
        {
            
        }


    }
}
