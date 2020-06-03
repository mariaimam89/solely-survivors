using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopaudioscript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource aaaa;
    public AudioClip clip1;
   // public AudioClip clip2;
    bool isplaying1 = false;

    public void playonbuttonclick1()
    {
        if (!isplaying1)
        {
            aaaa.PlayOneShot(clip1);
            isplaying1 = true;
        }
        else {
            aaaa.Stop();
            isplaying1 = false;

        }
    }
    //public void playobbuttonclick2()
    //{
    //    aaaa.PlayOneShot(clip2);
    //}
}
