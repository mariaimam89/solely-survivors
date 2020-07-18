using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Behaviour : MonoBehaviour
{
    public static bool intereact;
    public static bool give_hint;
    public AudioSource S1;
    public AudioSource S2;
    public AudioSource S3;
    public AudioSource S4;
    public GameObject Hint;
    void Start()
    {
        intereact = false;
    }


    void Update()
    {
        if (intereact) 
        {
            intereact = false;
            int x = Random.Range(0, 4);
            if (x == 0) 
            {
                S1.Play();
            }
            if (x == 1)
            {
                S2.Play();
            }
            if (x == 2)
            {
                S3.Play();
            }
            if (x == 3)
            {
                S4.Play();
            }

        }
        if (Input.GetKeyDown("h")&& give_hint) 
        {
            Hint.SetActive(true);
        }
        
    }
}
