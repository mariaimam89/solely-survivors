using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Power_Fast : MonoBehaviour

{

    public ParticleSystem A;
    bool ability;
    public float speed;
    void Start()
    {

        ability = true;
        
    }

    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            Debug.Log(ThirdPersonCharacter.speedability);


        }
        if (Input.GetKeyDown("r") && ability == true)
        {
            A.Play();
            ThirdPersonCharacter.speedability=speed;
           
    
            StartCoroutine(ability1());


        }

      

    }
    IEnumerator ability1()
    {
        yield return new WaitForSeconds(10);
        ability = false;
        ThirdPersonCharacter.speedability = 1f;
        A.Stop();
        StartCoroutine(ability2());

    }
    IEnumerator ability2()
    {
        yield return new WaitForSeconds(20);

        ability = true;
    }
}
