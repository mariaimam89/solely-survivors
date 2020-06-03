using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerttrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "coin")
        {
            Destroy(gameObject);
        }
    }
}
