using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
    Rigidbody2D rb;
    public int Nsaltos = 0;
    public int engranaje = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(Vector3.right * 15 * Input.GetAxisRaw("Horizontal"));

        //rb.velocity.x = Input.GetAxis("Horizontal");

        Vector2 vel = rb.velocity;
        vel.x = Mathf.Clamp(vel.x, -6, 6);
        rb.velocity = vel;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Nsaltos++;
            if(Nsaltos == 1)
            {
                //rb.AddForce(Vector3.up * 3, ForceMode2D.Impulse);
               // rb.velocity = (Vector3.up * 3);
                Nsaltos = 0;

            }
            /*else if(Nsaltos == 2)
            {
                rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            }*/
                
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
    }

}
