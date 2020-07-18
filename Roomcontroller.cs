using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Roomcontroller : MonoBehaviourPunCallbacks
{
    int CHECKER;
    //bool startgame;
    [SerializeField]
    private int multiplayerSceneindex;

    public override void OnEnable()
    {
        //startgame = false;
        PhotonNetwork.AddCallbackTarget(this);
    }

    public override void OnDisable()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("jOINED ROOM");
        
        Startgame();
    }
    public void Startgame()
    {
       // startgame = true;
            if (PhotonNetwork.IsMasterClient) 
            
                Debug.Log("starting game");
        if(GameManager.EN == "A") 
        {
            PhotonNetwork.LoadLevel(3);
        }
        if (GameManager.EN == "B")
        {
            PhotonNetwork.LoadLevel(1);
        }
        if (GameManager.EN == "C")
        {
            PhotonNetwork.LoadLevel(2);
        }


        //PhotonNetwork.LoadLevel(multiplayerSceneindex);
     
               
            

    }
    private void FixedUpdate()
    {
        //  if (PhotonNetwork.CountOfPlayers == 2)
        //  {
        //      PhotonNetwork.LoadLevel(multiplayerSceneindex);
        //   }
  /*      if (startgame) 
        {
            if (PhotonNetwork.CurrentRoom.PlayerCount == 2) 
            {
                startgame = false;
                PhotonNetwork.LoadLevel(multiplayerSceneindex);
            }
        }*/
    }
}
