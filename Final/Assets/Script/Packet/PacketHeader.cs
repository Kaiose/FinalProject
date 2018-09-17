using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DummyClient
{
    static class PacketMakeDate
    {
        static public string stamp()
        {
            return "2015/03/14 13:14:41";
        }
    }
    enum PacketType : long {
    /*128*/    E_C_REQ_EXIT = 128,
    /*129*/    E_S_ANS_EXIT = 129,
    /*130*/    E_I_NOTIFY_TERMINAL = 130,
    /*131*/    E_C_NOTIFY_HEARTBEAT = 131,
    /*132*/    E_C_REQ_ID_PW = 132,
    /*133*/    E_C_REQ_ID_PW_CHATTING = 133,
    /*134*/    E_C_REQ_ID_PW_GAME = 134,
    /*135*/    E_S_ANS_ID_PW_FAIL = 135,
    /*136*/    E_S_ANS_ID_PW_SUCCESS_CHATTING = 136,
    /*137*/    E_S_ANS_ID_PW_SUCCESS_GAME = 137,
    /*138*/    E_I_DB_REQ_ID_PW = 138,
    /*139*/    E_I_DB_ANS_ID_PW = 139,
    /*140*/    E_I_CHTTING_NOTIFY_ID = 140,
    /*141*/    E_I_DB_REQ_LOAD_DATA_CHATTING = 141,
    /*142*/    E_I_DB_ANS_PARSE_DATA_CHATTING = 142,
    /*143*/    E_I_LOGIN_NOTIFY_ID_LOADED_CHATTING = 143,
    /*144*/    E_C_REQ_REGIST_CHATTING_NAME = 144,
    /*145*/    E_C_REQ_CHATTING = 145,
    /*146*/    E_S_ANS_CHATTING = 146,
    /*147*/    E_S_ANS_CHATTING_EXIT = 147,
    /*148*/    E_C_REQ_CHATTING_EXIT = 148,
    /*149*/    E_S_ANS_GAME_EXIT = 149,
    /*150*/    E_C_REQ_GAME_EXIT = 150,
    /*151*/    E_I_LOGIN_NOTIFY_ID_LOADED_GAME = 151,
    /*152*/    E_I_DB_REQ_LOAD_DATA_GAME = 152,
    /*153*/    E_I_GAMING_NOTIFY_ID = 153,
    /*154*/    E_I_DB_ANS_PARSE_DATA_GAME = 154,
    /*155*/    E_I_DB_REQ_SAVE_DATA_GAME = 155,
    /*156*/    E_I_DB_ANS_SAVE_DATA_GAME = 156,
    /*157*/    E_C_REQ_REGIST_GAMING_CHARACTER_INFO = 157,
    /*158*/    E_C_REQ_MOVING = 158,
    /*159*/    E_S_ANS_MOVING = 159,
    /*160*/    E_C_REQ_JUMPING = 160,
    /*161*/    E_S_NOTIFY_ACCEPT_CLIENT = 161,
    /*162*/    E_C_REQ_MOVE_MAP = 162,
    /*163*/    E_S_ANS_MOVE_MAP = 163,
    /*164*/    E_C_REQ_VIRTUAL_MOVE = 164,
    /*165*/    E_S_ANS_VIRTUAL_MOVE = 165,
    /*166*/    E_C_REQ_REGIST_DATA = 166,
    /*167*/    E_S_ANS_REGIST_DATA = 167,
     }
};
