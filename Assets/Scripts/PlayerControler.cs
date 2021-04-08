using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5f;
    
    public Transform groundCheck;
    public bool isGrounded = true;
    public bool facingRight = true;

    public Animator Anim;
    public string sceneName;


    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

        if (Input.GetKeyDown("left")  && facingRight)
        {
            flip();
        }
        else if (Input.GetKeyDown("right") && !facingRight)
        {
            flip();
        }


    }
     
    private void FixedUpdate()
    {
        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Platform")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }


    void Jump()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Flag"))
        {

            StartCoroutine(LoadScene());
        }
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    IEnumerator LoadScene()
    {
        Anim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
