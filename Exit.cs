using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public string menu;
     void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void gameExitMain()
    {
        Application.LoadLevel(menu);
    }

    public void gameExit()
    {
        Application.Quit();
    }
}