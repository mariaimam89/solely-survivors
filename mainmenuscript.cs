using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mainmenuscript : MonoBehaviour
{

    public string menuname;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    
   
    public void onclickexit()
    {
        Application.LoadLevel(menuname);
    }
}
