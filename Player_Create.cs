using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class Player_Create : MonoBehaviour
{
    public bool test;
    
    void OnEnable()
    {
        if(test)
        GameManager.Chracter = "A";
        
        createplayer();

    }

    public void createplayer()
    {
        PhotonNetwork.Instantiate(Path.Combine("Photonprefabs", "Control"), Vector3.zero, Quaternion.identity);




        
    }
}
