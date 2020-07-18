using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisCamera : MonoBehaviour
{
    public GameObject parent;
    void Start()
    {

        PhotonView photonView = PhotonView.Get(parent);


        if (!photonView.IsMine) 
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
