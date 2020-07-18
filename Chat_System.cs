using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat_System : MonoBehaviour
{
    public GameObject Chat;
    bool toggle;
    void Start()
    {
        toggle = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            if (!toggle) 
            {
                Chat.SetActive(true);
                toggle = true;
            }
            else 
            {
                Chat.SetActive(false);
                toggle = false;
            }
        
        }
  
        
    }
}
