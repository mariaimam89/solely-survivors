using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class game_setup_controler : MonoBehaviour
{

    void Start()
    {
        createplayer();
    }

   public void createplayer() 
    {
        Debug.Log("creatingplayer");
        PhotonNetwork.Instantiate(Path.Combine("Photonprefabs", "Photonplayer"), Vector3.zero, Quaternion.identity);
    
    }
}
