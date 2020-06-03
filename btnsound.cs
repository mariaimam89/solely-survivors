using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnsound : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip clip1;
    public AudioClip clip2;


    public void hoversound()
    {
        sound.PlayOneShot(clip1);
    }
    public void clicksound()
    {
        sound.PlayOneShot(clip2);
    }

}
