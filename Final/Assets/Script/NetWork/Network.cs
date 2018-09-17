using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using UnityEngine;

namespace DummyClient
{


    public enum NET_STATE
    {
        START,
        CONNECTED,
        DISCONNECT,
        DISCONNECTED,
    }
    public class Network
    {


        private NetworkStream stream_;

        private TcpClient client_;

        private NET_STATE state_;

        private ContentsProcess ContentsProcee_;
        public Network(){

            stream_ = null;
            state_ = NET_STATE.START;
        }

        public void close()
        {
            state_ = NET_STATE.DISCONNECTED;
            stream_.Close();
            stream_.Flush();
            client_.Close();


            ContentsProcee_ = null;
        }
        
        public bool Connect(string ip, uint port)
        {
            client_ = new TcpClient();
            try
            {
                client_.Connect(ip, Convert.ToInt32(port));
            }
            catch
            {
                Debug.Log("Connect Failed");
                return false;
            }
            state_ = NET_STATE.CONNECTED;
            stream_ = client_.GetStream();

            return true;
        }
        public NET_STATE State()
        {
            return state_;
        }

        public void setContentsProcess(ContentsProcess contentsProcess)
        {
            ContentsProcee_ = contentsProcess;
        }

        private bool isConnected()
        {
            return state_ == NET_STATE.CONNECTED ? true : false;
        }

        public void receive()
        {
            if (stream_.DataAvailable)
            {
                Byte[] packetByte = new Byte[client_.ReceiveBufferSize];
                Int32 offset = 0;
                Int32 readLen = stream_.Read(packetByte, offset, packetByte.Length);

                PacketObfuscation.decodingHeader(ref packetByte, sizeof(Int32));

                Int32 packetLen = PacketUtil.decodePacketLen(packetByte, ref offset);


                while(readLen < packetLen)
                {
                    Byte[] remainPacket = new Byte[client_.ReceiveBufferSize];
                    Int32 remainLen = 0;
                    remainLen = stream_.Read(remainPacket, 0, remainPacket.Length);
                    Buffer.BlockCopy(remainPacket, 0, packetByte, readLen, remainLen);
                    readLen += remainLen;
                }
                Byte[] packetData = new Byte[client_.ReceiveBufferSize];

                Buffer.BlockCopy(packetByte, offset, packetData, 0, readLen - offset);
                PacketObfuscation.decodingData(ref packetData, packetData.Length);
                Packetinterface rowPacket = PacketUtil.packetAnalyzer(packetData);

                if(rowPacket == null && this.isConnected())
                {
                    Debug.Log("잘못된 패킷이 수신되었습니다.");
                }

                ContentsProcee_.run(rowPacket);

            }

        }


        public void sendPacket(Packetinterface packet)
        {
            try
            {
                packet.encode();
                //Header -> data 순으로 바이트변환후 packet내 외부스트림에 저장
                MemoryStream packetBlock = new MemoryStream();
                Int32 packetLen = sizeof(Int32) + (Int32)packet.getStream().Length;
               
                Byte[] packetHeader = BitConverter.GetBytes(packetLen);
                //packetHeader는 Packet의 총길이
                PacketObfuscation.encodingHeader(ref packetHeader, (int)packetHeader.Length);
                //길이 암호화
               packetBlock.Write(packetHeader, 0, (Int32)packetHeader.Length);


                Byte[] packetData = packet.getStream().ToArray();

                PacketObfuscation.encodingData(ref packetData, (int)packetData.Length);

                packetBlock.Write(packetData, 0, (Int32)packetData.Length);
                //실데이터 암호화후 블럭에 넣음

                Byte[] packetBytes = packetBlock.ToArray();
                // 블럭을 바이트로 변환
                stream_.Write(packetBytes,0, (int)packetBlock.Length);

                stream_.Flush();
                packetBlock = null;

            }catch(Exception e)
            {
                if (this.isConnected())
                {
                    Debug.Log("잘못된 처리 : send " + e.ToString());
                }
            }
        }
    }


}
