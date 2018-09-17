using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DummyClient
{
    public class PK_C_REQ_EXIT : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_EXIT; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_EXIT; }
        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_EXIT : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_EXIT; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_EXIT; }
        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_NOTIFY_TERMINAL : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_NOTIFY_TERMINAL; }
        Int64 type() { return (Int64) PacketType.E_I_NOTIFY_TERMINAL; }
        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_NOTIFY_HEARTBEAT : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_NOTIFY_HEARTBEAT; }
        Int64 type() { return (Int64) PacketType.E_C_NOTIFY_HEARTBEAT; }
        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_ID_PW : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_ID_PW; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_ID_PW; }
        public string         id_;
        public string         password_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, id_);
            PacketUtil.encode(packet_, password_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            id_ = PacketUtil.decodestring(packet, ref offset);
            password_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_ID_PW_CHATTING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_ID_PW_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_ID_PW_CHATTING; }
        public string         id_;
        public string         password_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, id_);
            PacketUtil.encode(packet_, password_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            id_ = PacketUtil.decodestring(packet, ref offset);
            password_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_ID_PW_GAME : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_ID_PW_GAME; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_ID_PW_GAME; }
        public string         id_;
        public string         password_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, id_);
            PacketUtil.encode(packet_, password_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            id_ = PacketUtil.decodestring(packet, ref offset);
            password_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_ID_PW_FAIL : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_ID_PW_FAIL; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_ID_PW_FAIL; }
        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_ID_PW_SUCCESS_CHATTING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_ID_PW_SUCCESS_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_ID_PW_SUCCESS_CHATTING; }
        public string         ip_;
        public UInt32         port_;
        public string         name_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, ip_);
            PacketUtil.encode(packet_, port_);
            PacketUtil.encode(packet_, name_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            ip_ = PacketUtil.decodestring(packet, ref offset);
            port_ = PacketUtil.decodeUInt32(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_ID_PW_SUCCESS_GAME : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_ID_PW_SUCCESS_GAME; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_ID_PW_SUCCESS_GAME; }
        public string         ip_;
        public UInt32         port_;
        public string         name_;
        public float         pointX_;
        public float         pointY_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, ip_);
            PacketUtil.encode(packet_, port_);
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pointX_);
            PacketUtil.encode(packet_, pointY_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            ip_ = PacketUtil.decodestring(packet, ref offset);
            port_ = PacketUtil.decodeUInt32(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
            pointX_ = PacketUtil.decodefloat(packet, ref offset);
            pointY_ = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_REQ_ID_PW : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_DB_REQ_ID_PW; }
        Int64 type() { return (Int64) PacketType.E_I_DB_REQ_ID_PW; }
        public UInt64         clientId_;
        public string         id_;
        public string         password_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, id_);
            PacketUtil.encode(packet_, password_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            id_ = PacketUtil.decodestring(packet, ref offset);
            password_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_ANS_ID_PW : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_DB_ANS_ID_PW; }
        Int64 type() { return (Int64) PacketType.E_I_DB_ANS_ID_PW; }
        public UInt64         clientId_;
        public UInt64         oidAccountId_;
        public Byte         result_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, oidAccountId_);
            PacketUtil.encode(packet_, result_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_CHTTING_NOTIFY_ID : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_CHTTING_NOTIFY_ID; }
        Int64 type() { return (Int64) PacketType.E_I_CHTTING_NOTIFY_ID; }
        public UInt64         clientId_;
        public UInt64         oidAccountId_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, oidAccountId_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_REQ_LOAD_DATA_CHATTING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_DB_REQ_LOAD_DATA_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_I_DB_REQ_LOAD_DATA_CHATTING; }
        public UInt64         clientId_;
        public UInt64         oidAccountId_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, oidAccountId_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_ANS_PARSE_DATA_CHATTING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_DB_ANS_PARSE_DATA_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_I_DB_ANS_PARSE_DATA_CHATTING; }
        public UInt64         clientId_;
        public string         name_;
        public Byte         result_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, result_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_LOGIN_NOTIFY_ID_LOADED_CHATTING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_LOGIN_NOTIFY_ID_LOADED_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_I_LOGIN_NOTIFY_ID_LOADED_CHATTING; }
        public UInt64         clientId_;
        public string         name_;
        public float         pointX_;
        public float         pointY_;
        public Byte         result_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pointX_);
            PacketUtil.encode(packet_, pointY_);
            PacketUtil.encode(packet_, result_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
            pointX_ = PacketUtil.decodefloat(packet, ref offset);
            pointY_ = PacketUtil.decodefloat(packet, ref offset);
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_REGIST_CHATTING_NAME : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_REGIST_CHATTING_NAME; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_REGIST_CHATTING_NAME; }
        public string         name_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_CHATTING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_CHATTING; }
        public string         text_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, text_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            text_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_CHATTING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_CHATTING; }
        public string         name_;
        public string         text_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, text_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            text_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_CHATTING_EXIT : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_CHATTING_EXIT; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_CHATTING_EXIT; }
        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_CHATTING_EXIT : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_CHATTING_EXIT; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_CHATTING_EXIT; }
        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_GAME_EXIT : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_GAME_EXIT; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_GAME_EXIT; }
        public string         name_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_GAME_EXIT : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_GAME_EXIT; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_GAME_EXIT; }
        public string         name_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_LOGIN_NOTIFY_ID_LOADED_GAME : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_LOGIN_NOTIFY_ID_LOADED_GAME; }
        Int64 type() { return (Int64) PacketType.E_I_LOGIN_NOTIFY_ID_LOADED_GAME; }
        public UInt64         clientId_;
        public string         name_;
        public float         pointX_;
        public float         pointY_;
        public Byte         result_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pointX_);
            PacketUtil.encode(packet_, pointY_);
            PacketUtil.encode(packet_, result_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
            pointX_ = PacketUtil.decodefloat(packet, ref offset);
            pointY_ = PacketUtil.decodefloat(packet, ref offset);
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_REQ_LOAD_DATA_GAME : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_DB_REQ_LOAD_DATA_GAME; }
        Int64 type() { return (Int64) PacketType.E_I_DB_REQ_LOAD_DATA_GAME; }
        public UInt64         clientId_;
        public UInt64         oidAccountId_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, oidAccountId_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_GAMING_NOTIFY_ID : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_GAMING_NOTIFY_ID; }
        Int64 type() { return (Int64) PacketType.E_I_GAMING_NOTIFY_ID; }
        public UInt64         clientId_;
        public UInt64         oidAccountId_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, oidAccountId_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_ANS_PARSE_DATA_GAME : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_DB_ANS_PARSE_DATA_GAME; }
        Int64 type() { return (Int64) PacketType.E_I_DB_ANS_PARSE_DATA_GAME; }
        public UInt64         clientId_;
        public string         name_;
        public float         pointX_;
        public float         pointY_;
        public Byte         result_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pointX_);
            PacketUtil.encode(packet_, pointY_);
            PacketUtil.encode(packet_, result_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
            pointX_ = PacketUtil.decodefloat(packet, ref offset);
            pointY_ = PacketUtil.decodefloat(packet, ref offset);
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_REQ_SAVE_DATA_GAME : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_DB_REQ_SAVE_DATA_GAME; }
        Int64 type() { return (Int64) PacketType.E_I_DB_REQ_SAVE_DATA_GAME; }
        public string         name_;
        public float         pointX_;
        public float         pointY_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pointX_);
            PacketUtil.encode(packet_, pointY_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pointX_ = PacketUtil.decodefloat(packet, ref offset);
            pointY_ = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_ANS_SAVE_DATA_GAME : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_I_DB_ANS_SAVE_DATA_GAME; }
        Int64 type() { return (Int64) PacketType.E_I_DB_ANS_SAVE_DATA_GAME; }
        public Byte         result_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, result_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_REGIST_GAMING_CHARACTER_INFO : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_REGIST_GAMING_CHARACTER_INFO; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_REGIST_GAMING_CHARACTER_INFO; }
        public string         name_;
        public float         pointX_;
        public float         pointY_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pointX_);
            PacketUtil.encode(packet_, pointY_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pointX_ = PacketUtil.decodefloat(packet, ref offset);
            pointY_ = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_MOVING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_MOVING; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_MOVING; }
        public string         name_;
        public float         pos_X;
        public float         pos_Y;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pos_X);
            PacketUtil.encode(packet_, pos_Y);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pos_X = PacketUtil.decodefloat(packet, ref offset);
            pos_Y = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_MOVING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_MOVING; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_MOVING; }
        public string         name_;
        public float         pos_X;
        public float         pos_Y;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pos_X);
            PacketUtil.encode(packet_, pos_Y);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pos_X = PacketUtil.decodefloat(packet, ref offset);
            pos_Y = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_JUMPING : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_JUMPING; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_JUMPING; }
        public string         name_;
        public float         pos_X;
        public float         pos_Y;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pos_X);
            PacketUtil.encode(packet_, pos_Y);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pos_X = PacketUtil.decodefloat(packet, ref offset);
            pos_Y = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_NOTIFY_ACCEPT_CLIENT : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_NOTIFY_ACCEPT_CLIENT; }
        Int64 type() { return (Int64) PacketType.E_S_NOTIFY_ACCEPT_CLIENT; }
        public UInt64         oidAccountId_;
        public string         name_;
        public float         pos_X;
        public float         pos_Y;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, oidAccountId_);
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pos_X);
            PacketUtil.encode(packet_, pos_Y);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
            pos_X = PacketUtil.decodefloat(packet, ref offset);
            pos_Y = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_MOVE_MAP : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_MOVE_MAP; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_MOVE_MAP; }
        public string         name_;
        public float         pos_X;
        public float         pos_Y;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pos_X);
            PacketUtil.encode(packet_, pos_Y);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pos_X = PacketUtil.decodefloat(packet, ref offset);
            pos_Y = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_MOVE_MAP : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_MOVE_MAP; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_MOVE_MAP; }
        public string         name_;
        public float         pos_X;
        public float         pos_Y;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pos_X);
            PacketUtil.encode(packet_, pos_Y);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pos_X = PacketUtil.decodefloat(packet, ref offset);
            pos_Y = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_VIRTUAL_MOVE : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_VIRTUAL_MOVE; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_VIRTUAL_MOVE; }
        public string         name_;
        public float         pos_X;
        public float         pos_Y;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pos_X);
            PacketUtil.encode(packet_, pos_Y);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pos_X = PacketUtil.decodefloat(packet, ref offset);
            pos_Y = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_VIRTUAL_MOVE : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_VIRTUAL_MOVE; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_VIRTUAL_MOVE; }
        public string         name_;
        public float         pos_X;
        public float         pos_Y;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, pos_X);
            PacketUtil.encode(packet_, pos_Y);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            pos_X = PacketUtil.decodefloat(packet, ref offset);
            pos_Y = PacketUtil.decodefloat(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_REGIST_DATA : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_C_REQ_REGIST_DATA; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_REGIST_DATA; }
        public string         name_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_REGIST_DATA : PacketData, Packetinterface
    {
        Int64 Packetinterface.type() { return (Int64) PacketType.E_S_ANS_REGIST_DATA; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_REGIST_DATA; }
        public string         name_;

        void Packetinterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void Packetinterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream Packetinterface.getStream()
        {
            return packet_;
        }
    }
}
