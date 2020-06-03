using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logopanelcsript : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject thispanel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
       


    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4f);
        menupanel.SetActive(true);
        thispanel.SetActive(false);
    }
    
}