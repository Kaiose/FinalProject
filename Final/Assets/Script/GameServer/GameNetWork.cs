using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DummyClient
{

    public class GameNetWork : MonoBehaviour
    {

        static protected GameNetWork gameNetWork;
        static public GameNetWork getInstance { get { return gameNetWork; } }


        protected Network network_;
        public string name_;

        private void Awake()
        {
            gameNetWork = this;
        }
        private void Start()
        {
            DontDestroyOnLoad(this);
            if (network_ == null)
                network_ = new Network();
        }

        private void OnDestroy()
        {
            PK_C_REQ_GAME_EXIT exitPacket = new PK_C_REQ_GAME_EXIT();
            exitPacket.name_ = name_;
            sendPacket(exitPacket);

        }
        
        public bool ConnectToServer(string ip, uint port)
        {
            return network_.Connect(ip, port);
        }

        public void Open(string ip, uint port)
        {
            if (!ConnectToServer(ip, port))
            {
                Debug.Log("Game Server Connect Failed");
            }

            network_.setContentsProcess(new GameContentsProcess());
            StartCoroutine(recv());
        }

        public NET_STATE GetState()
        {
            return network_.State();
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
