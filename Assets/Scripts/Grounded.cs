using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public GameObject Player;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Player.GetComponent<PlayerControler>().isGrounded = true;
        }
        else
        {
            Player.GetComponent<PlayerControler>().isGrounded = false;
        }

    }

    
}


