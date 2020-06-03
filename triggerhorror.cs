using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class triggerhorror : MonoBehaviour
{
    public GameObject panel;
    private int maxNumbers = 2;
    public List<int> uniqueNumbers = new List<int>();
    private List<int> finishedList;
    public Text score;
    int scorecount = 0;
    public int count = 0;
    int randomindex;
    public GameObject[] objectsarray;
    string[] hints = { "Sitting area", "Go play in the room"};
    //"The hottest pizza in town", "Symbol of Feminism",
    //"Sky holds the sky Scrapper"};
    public Text text;
    GameObject generatedobject;
    // Start is called before the first frame update
    void Start()

    {
        for (int i = 0; i < maxNumbers; i++)
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
        if (generatedobject.tag == "cube" & other.tag == "cube")
        {
            objectsarray[randomindex].SetActive(false);
            scorecount += 50;
            score.text = scorecount.ToString();
            //Destroy(objectsarray[randomindex]);
            count++;
            if (count < objectsarray.Length)
            {
                random();
            }
            else
            {
                scorecount += 100;
                score.text = scorecount.ToString();
                panel.SetActive(true);
                // text.text = "You won";
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
        text.text = "Hint " + (count + 1) + ": " + hints[randomindex];
        objectsarray[randomindex].SetActive(true);
        generatedobject = objectsarray[randomindex];






    }
}



