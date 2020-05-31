using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_obsticle : MonoBehaviour
{

    public GameObject hurdel;
    public Transform target;
    float cooldown;
    void Start()
    {
        cooldown = 5;
    }

   
    void Update()
    {
        if (cooldown < 3) 
        { 
        cooldown += Time.deltaTime;
        }
        if (Input.GetKeyDown("r")&&cooldown>0)
        {
            Instantiate(hurdel, target.position, Quaternion.identity);
            cooldown--;
        }

    }
 
}
