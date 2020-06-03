using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class trigger : MonoBehaviour
{

    int scorecount=0;
    public GameObject panel;
    private int maxNumbers = 7;
    public List<int> uniqueNumbers = new List<int>();
    private List<int> finishedList;
    public Text Score;
    public int count = 0;
    int randomindex;
    public GameObject[] objectsarray;
    string[] hints = { "Some humble abode", "Seek Protection from the aggressor" , "Years old killer trick for the lost ones",
    "A symbol of power for the chen dynasty for thousand of years", "The looted treasure box of the second century",
    "Fossils of the Mongol warrior", "Whatever's left of the young traveler's belongings"};
    public Text text;
    GameObject generatedobject;
    // Start is called before the first frame update
    void Start()

    {
        for(int i = 0; i < maxNumbers; i++)
        {
            uniqueNumbers.Add(i);
        }
     
       
        random();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void initiate()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (generatedobject.tag=="cube" & other.tag == "cube")
        {
           objectsarray[randomindex].SetActive(false);
            scorecount += 50;
            Score.text = scorecount.ToString();          
            //Destroy(objectsarray[randomindex]);
            count++;
            if (count < objectsarray.Length)
            {
                random();
            }
            else
            {
                //win
                scorecount += 100;
                Score.text = scorecount.ToString();
                panel.SetActive(true);
               
            }
                    }
        //if (generatedobject.tag == "sphere" & other.tag == "sphere")
        //{
        //    objectsarray[randomindex].SetActive(false);
        //    //Destroy(objectsarray[randomindex]);
        //    count++;
        //    if (count < objectsarray.Length)
        //    {
        //        random();
        //    }
        //    else
        //    {
        //        text.text = "You won";
        //    }

      //  }

    }

    void random()
    {

        
            int index = Random.Range(0, uniqueNumbers.Count);

            randomindex = uniqueNumbers[index];
            uniqueNumbers.Remove(randomindex);




            //randomindex = Random.Range(0, objectsarray.Length);
        text.text = "Hint "+ (count+1) +": "+ hints[randomindex];
        objectsarray[randomindex].SetActive(true);
        generatedobject = objectsarray[randomindex];
     





    }
}


