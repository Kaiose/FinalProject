using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DummyClient
{
    public static class PacketFactory
    {
        public static Packetinterface getPacket(Int64 packetType) 
        {
            switch ((PacketType)packetType)
            {
                case PacketType.E_C_REQ_EXIT:    return new PK_C_REQ_EXIT();
                case PacketType.E_S_ANS_EXIT:    return new PK_S_ANS_EXIT();
                case PacketType.E_I_NOTIFY_TERMINAL:    return new PK_I_NOTIFY_TERMINAL();
                case PacketType.E_C_NOTIFY_HEARTBEAT:    return new PK_C_NOTIFY_HEARTBEAT();
                case PacketType.E_C_REQ_ID_PW:    return new PK_C_REQ_ID_PW();
                case PacketType.E_C_REQ_ID_PW_CHATTING:    return new PK_C_REQ_ID_PW_CHATTING();
                case PacketType.E_C_REQ_ID_PW_GAME:    return new PK_C_REQ_ID_PW_GAME();
                case PacketType.E_S_ANS_ID_PW_FAIL:    return new PK_S_ANS_ID_PW_FAIL();
                case PacketType.E_S_ANS_ID_PW_SUCCESS_CHATTING:    return new PK_S_ANS_ID_PW_SUCCESS_CHATTING();
                case PacketType.E_S_ANS_ID_PW_SUCCESS_GAME:    return new PK_S_ANS_ID_PW_SUCCESS_GAME();
                case PacketType.E_I_DB_REQ_ID_PW:    return new PK_I_DB_REQ_ID_PW();
                case PacketType.E_I_DB_ANS_ID_PW:    return new PK_I_DB_ANS_ID_PW();
                case PacketType.E_I_CHTTING_NOTIFY_ID:    return new PK_I_CHTTING_NOTIFY_ID();
                case PacketType.E_I_DB_REQ_LOAD_DATA_CHATTING:    return new PK_I_DB_REQ_LOAD_DATA_CHATTING();
                case PacketType.E_I_DB_ANS_PARSE_DATA_CHATTING:    return new PK_I_DB_ANS_PARSE_DATA_CHATTING();
                case PacketType.E_I_LOGIN_NOTIFY_ID_LOADED_CHATTING:    return new PK_I_LOGIN_NOTIFY_ID_LOADED_CHATTING();
                case PacketType.E_C_REQ_REGIST_CHATTING_NAME:    return new PK_C_REQ_REGIST_CHATTING_NAME();
                case PacketType.E_C_REQ_CHATTING:    return new PK_C_REQ_CHATTING();
                case PacketType.E_S_ANS_CHATTING:    return new PK_S_ANS_CHATTING();
                case PacketType.E_S_ANS_CHATTING_EXIT:    return new PK_S_ANS_CHATTING_EXIT();
                case PacketType.E_C_REQ_CHATTING_EXIT:    return new PK_C_REQ_CHATTING_EXIT();
                case PacketType.E_S_ANS_GAME_EXIT:    return new PK_S_ANS_GAME_EXIT();
                case PacketType.E_C_REQ_GAME_EXIT:    return new PK_C_REQ_GAME_EXIT();
                case PacketType.E_I_LOGIN_NOTIFY_ID_LOADED_GAME:    return new PK_I_LOGIN_NOTIFY_ID_LOADED_GAME();
                case PacketType.E_I_DB_REQ_LOAD_DATA_GAME:    return new PK_I_DB_REQ_LOAD_DATA_GAME();
                case PacketType.E_I_GAMING_NOTIFY_ID:    return new PK_I_GAMING_NOTIFY_ID();
                case PacketType.E_I_DB_ANS_PARSE_DATA_GAME:    return new PK_I_DB_ANS_PARSE_DATA_GAME();
                case PacketType.E_I_DB_REQ_SAVE_DATA_GAME:    return new PK_I_DB_REQ_SAVE_DATA_GAME();
                case PacketType.E_I_DB_ANS_SAVE_DATA_GAME:    return new PK_I_DB_ANS_SAVE_DATA_GAME();
                case PacketType.E_C_REQ_REGIST_GAMING_CHARACTER_INFO:    return new PK_C_REQ_REGIST_GAMING_CHARACTER_INFO();
                case PacketType.E_C_REQ_MOVING:    return new PK_C_REQ_MOVING();
                case PacketType.E_S_ANS_MOVING:    return new PK_S_ANS_MOVING();
                case PacketType.E_C_REQ_JUMPING:    return new PK_C_REQ_JUMPING();
                case PacketType.E_S_NOTIFY_ACCEPT_CLIENT:    return new PK_S_NOTIFY_ACCEPT_CLIENT();
                case PacketType.E_C_REQ_MOVE_MAP:    return new PK_C_REQ_MOVE_MAP();
                case PacketType.E_S_ANS_MOVE_MAP:    return new PK_S_ANS_MOVE_MAP();
                case PacketType.E_C_REQ_VIRTUAL_MOVE:    return new PK_C_REQ_VIRTUAL_MOVE();
                case PacketType.E_S_ANS_VIRTUAL_MOVE:    return new PK_S_ANS_VIRTUAL_MOVE();
                case PacketType.E_C_REQ_REGIST_DATA:    return new PK_C_REQ_REGIST_DATA();
                case PacketType.E_S_ANS_REGIST_DATA:    return new PK_S_ANS_REGIST_DATA();
            }
            return null;
        }
    }
}
