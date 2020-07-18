using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscript : MonoBehaviour
{
    PhotonView vp;
    void Start()
    {
        vp.GetComponent<PhotonView>();
    }

    // Update is called once per frame
   
}
