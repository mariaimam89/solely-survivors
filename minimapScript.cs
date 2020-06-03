using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapScript : MonoBehaviour
{
     public Transform player;
    public Transform A;
    public Transform B;
    public Transform C;
    public Transform D;
    void Start()
    {
        if (GameManager.Chracter == "A")
        {
            player = A;
        }
        if (GameManager.Chracter == "B")
        {
            player = B;
        }
        if (GameManager.Chracter == "C")
        {
            player = C;
        }
        if (GameManager.Chracter == "D")
        {
            player = D;
        }

    }
    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}
