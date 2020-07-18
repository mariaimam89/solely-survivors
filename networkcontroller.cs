using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class networkcontroller : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("WE ARE CONNECT TO THE " + PhotonNetwork.CloudRegion + "server");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
