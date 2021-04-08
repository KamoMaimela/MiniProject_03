using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate_Button : MonoBehaviour
{
    public GameObject Balance;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Button"))
        {
            Balance.SetActive(false);
        }
    }
}
