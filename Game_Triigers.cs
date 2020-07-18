using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Triigers : MonoBehaviour
{
    public GameObject Parent;
    
    public void Start() 
    {
        PhotonView photonView = PhotonView.Get(Parent);
       
        if (!photonView.IsMine) 
        {
            this.gameObject.GetComponent<Game_Triigers>().enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        PhotonView photonView = PhotonView.Get(Parent);
     
        if (other.tag == "cam" && photonView.IsMine) 
        {
            Game_Logics.Game_Score++;
            Game_Logics.collect_object = true;
            Destroy(other.gameObject);
        }
        if (other.tag == "coin" && photonView.IsMine)
        {
            Game_Logics.Game_Score++;
            Update_UI.gold += 100;
            Game_Logics.collect_object = true;
            Destroy(other.gameObject);
        }
        if (other.tag == "trademill" && photonView.IsMine)
        {
            Game_Logics.Game_Score++;
            Game_Logics.collect_object = true;
            Destroy(other.gameObject);
        }
        if (other.tag == "boll" && photonView.IsMine)
        {
            Game_Logics.Game_Score++;
            Game_Logics.collect_object = true;
            Destroy(other.gameObject);
        }
        if (other.tag == "enemy" && photonView.IsMine)
        {
            
        }
        if (other.tag == "npc" && photonView.IsMine)
        {
            NPC_Behaviour.intereact = true;
            NPC_Behaviour.give_hint = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        PhotonView photonView = PhotonView.Get(Parent);
       
        if (other.tag == "npc" && photonView.IsMine)
        {
            NPC_Behaviour.give_hint = false;
        }
    }
}
