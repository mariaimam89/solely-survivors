using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_UI : MonoBehaviour
{
    public Text coin;
    public Text score;
    public static int gold;
    void OnEnable()
    {
        InvokeRepeating("updateUI", 0, .5f);
    }


    private void OnDisable()
    {
        CancelInvoke();
    }

    public void updateUI() 
    {
        coin.text = gold.ToString();
        score.text = Game_Logics.Game_Score.ToString();
    }
}
