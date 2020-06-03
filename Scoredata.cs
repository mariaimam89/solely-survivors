using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoredata : MonoBehaviour
{
  
    public GameObject Menu;
    public GameObject ScoreScreen;
    public Text Score;
    public Text difficulty;
    string a;
    string b;
    int temp;
    bool x = false;
    private float time = 0.0f;
    public float interpolationPeriod = 2f;

    void Start()
    {
        
         a = data.marks.ToString();
        temp = data.marks;
        if (temp <= 3)
        {
            b = "EASY";
        }
        if (temp <= 7 && temp >= 4)
        {
            b = "Medium";
        }
        if (temp >= 8)
        {
            b = "Hard";
        }
        Score.text = a;
        difficulty.text = b;
    }
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;

            if (Input.GetMouseButton(0))
            {
                Menu.active = true;

                ScoreScreen.active = false;
            }
    }
}
}
