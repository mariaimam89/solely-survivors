using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMap : MonoBehaviour
{

    public GameObject disable;
    public GameObject enable;

    void Start()
    {
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate () { gameC(); });

    }

    public void gameC()
    {
        disable.SetActive(false);
        enable.SetActive(true);
    }
}

