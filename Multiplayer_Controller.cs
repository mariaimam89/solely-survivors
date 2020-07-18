using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Multiplayer_Controller : MonoBehaviour
{
    public static bool Game_win;
    public static bool Game_lose;
    void OnEnable()
    {
        Game_win = false;
        Game_lose = false;
        PhotonView photonView = PhotonView.Get(this);   
        enabled = photonView.IsMine;
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_win == true)
        {
            Game_win = false;
            PhotonView photonView = PhotonView.Get(this);
            photonView.RPC("Win", RpcTarget.Others, true);
            
        }
        
    }

    [PunRPC]
    public void Win(bool a)
    {
        Game_lose = a;

    }
}
