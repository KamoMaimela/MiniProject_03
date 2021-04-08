using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private int health = 5;

    //materials
    public Color grey = Color.grey;
    public Color black = Color.black;
   
    SpriteRenderer sr;

    public Slider Health;
    

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health--;
            Health.value--;
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

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

    private void Default()
    {
        sr.color = black;
    }

    private void KillSelf()
    {
        Destroy(gameObject);
    }

}