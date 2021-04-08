using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private int health = 2;

    //materials
    public Color grey = Color.grey;
    public Color black = Color.black;

    SpriteRenderer sr;

    public GameObject words;
    public GameObject words2;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health--;
            sr.color = grey;

            if (health <= 0)
            {
                KillSelf();
            }
            else
            {
                Invoke("Default", .2f);
            }
        }
    }

    private void Default()
    {
        sr.color = black;
    }

    private void KillSelf()
    {
        Destroy(gameObject);
        words.SetActive(false);
        words2.SetActive(true);
    }

}