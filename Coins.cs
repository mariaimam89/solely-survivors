using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{


    public static int coin;
    public Text txt;
    

     void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(0, 100*Time.deltaTime, 0);

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            coin++;

            txt.text = coin.ToString();
            Destroy(gameObject);
        }
    }
}
