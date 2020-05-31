using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscenesequence : MonoBehaviour
{
    public GameObject came1;
    public GameObject came2;
    public GameObject came3;
    public GameObject camemain;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }
    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(4);
        came2.SetActive(true);
        came1.SetActive(false);
        yield return new WaitForSeconds(4);
        came3.SetActive(true);
        came2.SetActive(false);
        yield return new WaitForSeconds(4);
        camemain.SetActive(true);
        came3.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
