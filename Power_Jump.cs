using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Power_Jump : MonoBehaviour
    
{
    public ParticleSystem A;
    bool ability;
    public float jump_power;
    void Start()
    {
        
        ability = true;
    }
  
    void Update()
    {
        
        if (Input.GetKeyDown("r") && ability ==true)
        {
            A.Play();
            ThirdPersonCharacter.jumpability= jump_power;
            
     
            
            StartCoroutine(ability1());
            

        }

    }
    IEnumerator ability1()
    {
        yield return new WaitForSeconds(2);
        ability = false;
        ThirdPersonCharacter.jumpability = 1f;
        StartCoroutine(ability2());
       
    }
    IEnumerator ability2() {
        yield return new WaitForSeconds(2);
        
        ability = true;
    }
}
