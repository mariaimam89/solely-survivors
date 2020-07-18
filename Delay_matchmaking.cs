using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delay_matchmaking : MonoBehaviour
{

    public int playerCount;

    void Update()
    {
        if (playerCount == 2)
        {
            // PhotonNetwork.LoadLevel(SceneNameGame);
            Debug.Log("afwagfwagwaggawgwa");
        }
    }

    void OnJoinedRoom()
    {
        PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("UpdatePlayerCount", RpcTarget.All, true);
    }

    void OnLeftRoom()
    {
        PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("UpdatePlayerCount", RpcTarget.All, false);
    }

    [PunRPC]
    void UpdatePlayerCount(bool AddToCount)
    {
        if (AddToCount)
        {
            playerCount += 1;
        }
        else
        {
            playerCount -= 1;
        }
    }
}
