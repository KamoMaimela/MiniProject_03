using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float offset;
    public GameObject Player;

    void Start()
    {

    }

    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = Player.transform.position.x;
        temp.y = Player.transform.position.y + 1.5f;

        temp.x += offset;

        transform.position = temp;
    }

  
}
