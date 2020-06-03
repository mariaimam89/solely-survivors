using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelshow : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    
       

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
        panel.SetActive(false);
        panel1.SetActive(true);

    }
}