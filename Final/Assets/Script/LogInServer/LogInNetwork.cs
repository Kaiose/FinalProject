using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DummyClient
{
    public class LogInNetwork : MonoBehaviour
    {
        static protected LogInNetwork logInNetwork;
        static public LogInNetwork getInstance { get { return logInNetwork; } }

        protected Network network_;

        //        private string loginIp_ = "192.168.10.7";//"127.0.0.1"; 192.168.10.15
        private string loginIp_ = "127.0.0.1";
        private uint loginPort_ = 9000;


        private void Awake()
        {
            logInNetwork = this;
        }
        //LogInContentsProcess logInContentsProcess = null;

        // Use this for initialization
        void Start()
        {
            //logInContentsProcess = new LogInContentsProcess();

            Open();
            StartCoroutine(recv());

            DontDestroyOnLoad(this);
        }

        private void OnDestroy()
        {
            disconnect();
        }

        public bool ConnectToServer(string ip, uint port)
        {
            if (network_ == null)
            {
                network_ = new Network();
                Debug.Log("Network 객체 생성");
            }
            else
            {
                Debug.Log("Network 객체 생성 실패");

            }
            return network_.Connect(ip, port);


        }

        // Update is called once per frame
        void Update()
        {
            //    if (//GameObject.Find("ChattingNetWork").GetComponent<ChattingNetWork>().GetState() == NET_STATE.CONNECTED &&
            //       GameObject.Find("GameNetWork").GetComponent<GameNetWork>().GetState() == NET_STATE.CONNECTED)
            //        Destroy(this);
            //

        }


        public void Open()
        {
            if (!ConnectToServer(loginIp_, loginPort_))
            {
                Debug.Log("로그인 서버 연결 실패");
 
            }

            network_.setContentsProcess(new LogInContentsProcess());
        }

        public void disconnect()
        {
            
            network_.close();
        }

       public void sendPacket(Packetinterface packet)
        {
            network_.sendPacket(packet);
        }


        IEnumerator recv()
        {
            while (true)
            {
                network_.receive();

                yield return null;
            }
        }
    }
}