using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Activator : MonoBehaviour
{
    public GameObject Cinematic;
    public GameObject Activator;
    public int time_of_cinematic;
    void OnEnable()
    {
        Cinematic.SetActive(true);
        Invoke("Start_Game", time_of_cinematic);
    }

    public void Start_Game() 
    {
        Cinematic.SetActive(false);
        Activator.SetActive(true);
    }
}
