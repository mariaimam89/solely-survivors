using System.Collections;
using Photon.Pun;
using Photon.Realtime;
using System.Collections.Generic;
using UnityEngine;

public class quick_start : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject quickStartButton;
    [SerializeField]
    private GameObject quickcancelButton;
    [SerializeField]
    private int RoomSize;
 
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        quickStartButton.SetActive(true);
      //  PhotonNetwork.JoinRandomRoom();
        //Debug.Log("Quick Start");
    }

    public void quickstart() 
    {
        quickStartButton.SetActive(false);
        quickcancelButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("quickstart");
    
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to join the room");
        CreateRoom();
    }
    void CreateRoom() 
    {
        Debug.Log("cREATING ROOM ");
        int randomRoomNumber = Random.Range(0, 10000);
        RoomOptions roomOps = new RoomOptions()
        { IsVisible = true,IsOpen = true,MaxPlayers = (byte)RoomSize};
        PhotonNetwork.CreateRoom("Room" + randomRoomNumber, roomOps);
        Debug.Log(randomRoomNumber);
        
    }

    public override void OnCreateRoomFailed (short returncode,string message) 
    {
        Debug.Log("Failed to create room .. tryign again");
        CreateRoom();
    }

    public void QuickCancel() 
    {
        quickcancelButton.SetActive(false);
        quickStartButton.SetActive(true);
        PhotonNetwork.LeaveRoom();
    
    }
   
}
