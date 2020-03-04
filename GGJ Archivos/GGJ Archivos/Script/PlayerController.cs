using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 90f;
    public float Maxspeed = 3.5f;
    public float saltoPower = 11f;
    private bool saltoB;
    public bool tocoSuelo;

    private Rigidbody2D rb2;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && tocoSuelo)
        {
            saltoB = true;
        }

        animator.SetFloat("Speed", Mathf.Abs(rb2.velocity.x));
        animator.SetBool("SobreSuelo", tocoSuelo); 
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rb2.AddForce(Vector2.right * speed * h);

        if(rb2.velocity.x > Maxspeed)
        {
            rb2.velocity = new Vector2(Maxspeed,rb2.velocity.y);
        }
        if(rb2.velocity.x < -Maxspeed)
        {
            rb2.velocity = new Vector2(-Maxspeed,rb2.velocity.y);
        }
        
        if(saltoB)
        {
            rb2.AddForce(Vector2.up * saltoPower,ForceMode2D.Impulse);
            saltoB = false;
        }  



        if(h > 0.1f)
        {
            transform.localScale = new Vector3(1f,1f,1f);
        }
        if(h < -0.1f)
        {
            transform.localScale = new Vector3(-1f,1f,1f);
        }
    }
    


}
