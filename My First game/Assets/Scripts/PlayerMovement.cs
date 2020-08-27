
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 30;
    public float JumpForce = 20;
    private Rigidbody2D rb;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = Vector2.right * speed;
      
    }

    // Update is called once per frame
    void Update()
    { 
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && !isJumping)
        {
            rb.velocity = Vector2.up * JumpForce; // or rb.AddForce(Vector2.up * JumpForce);
            isJumping = true;
        }



    }
     void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        } 
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Death"))
        {
            SceneManager.LoadScene(0);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
}

