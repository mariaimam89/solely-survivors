using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Logics : MonoBehaviour
{
    public static int Game_Score;
    //public static int Enemy_Score;
    public GameObject Win_Panel;
    public GameObject Lose_Panel;
    public static bool collect_object;
    public GameObject accept_Image;
    private void OnEnable()
    {
        //reset
        Game_Score = 0;
        collect_object = false;
       // Enemy_Score = 0;
    }

    public void Update()
    {
        if (Game_Score >= 5) 
        {
            Game_Score = 0;
            Multiplayer_Controller.Game_win = true;
            Win_Panel.SetActive(true);
            PlayerPrefs.SetInt("game_gold", PlayerPrefs.GetInt("game_gold")+ Update_UI.gold);
            Update_UI.gold = 0;

        }

        if (Multiplayer_Controller.Game_lose == true) 
        {
            Multiplayer_Controller.Game_lose = false;
            Lose_Panel.SetActive(true);
            PlayerPrefs.SetInt("game_gold", PlayerPrefs.GetInt("game_gold") + Update_UI.gold);
            Update_UI.gold = 0;


        }
        if (collect_object) 
        {
            collect_object = false;
            accept_Image.SetActive(true);

        }

    }
            
    public void exit_key()
        {
            PhotonNetwork.Disconnect();
            PhotonNetwork.LeaveRoom();
            SceneManager.LoadScene("asmamenuscene");
        }
    


}
