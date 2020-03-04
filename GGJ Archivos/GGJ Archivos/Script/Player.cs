using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
    Rigidbody2D rb;
    public float speed = 2;
    public bool isGrounded = true;
    public int engranaje = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = (Vector3.up * 15);
            isGrounded = false;


        }

    }
    // Update is called once per frame


    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), rb.velocity.y) * speed;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Engranaje")
        {
            Destroy(other.gameObject);
            engranaje = 1;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "door01" && engranaje == 1)
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Map")
        {
            isGrounded = true;
        }
    }
}
