using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Multiplayer_Configure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonView Pv;
        Pv = GetComponent<PhotonView>();
        if (Pv.IsMine)
        {
            createplayer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void createplayer()
    {
        if (GameManager.Chracter == "A")
        {
            PhotonNetwork.Instantiate(Path.Combine("Photonprefabs", "CharacterA"), Vector3.zero, Quaternion.identity);

        }
        if (GameManager.Chracter == "B")
        {
            PhotonNetwork.Instantiate(Path.Combine("Photonprefabs", "CharacterB"), Vector3.zero, Quaternion.identity);

        }
        if (GameManager.Chracter == "C")
        {
            PhotonNetwork.Instantiate(Path.Combine("Photonprefabs", "CharacterC"), Vector3.zero, Quaternion.identity);

        }
        if (GameManager.Chracter == "D")
        {
            PhotonNetwork.Instantiate(Path.Combine("Photonprefabs", "CharacterD"), Vector3.zero, Quaternion.identity);

        }

    }
}
