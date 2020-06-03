using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuanimationsound : MonoBehaviour
{

    public AudioSource Audi;
    public AudioClip ac;
    
    // Start is called before the first frame update
    void Start()
    {
        play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void play()
    {
        Audi.PlayOneShot(ac);
    }
}
