using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public float speed = 10f;
    public float LifeTime = 2f;
    

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        Invoke("DestroyBullet", LifeTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Crates"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Flag"))
        {
            Destroy(gameObject);
        }
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

   
}
