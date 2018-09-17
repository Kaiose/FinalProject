using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DummyClient;
using UnityEngine.UI;

public class LogInClick : MonoBehaviour {


    public InputField ID;
    public InputField PW;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Click();
        }
	}


    public void Click()
    {
        PK_C_REQ_ID_PW packet = new PK_C_REQ_ID_PW();
        packet.id_ = "kinam";
        packet.password_ = "111";
        
        LogInNetwork.getInstance.sendPacket(packet);
    }
}
