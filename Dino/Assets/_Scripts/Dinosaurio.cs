using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaurio : MonoBehaviour {

    public Rigidbody2D rb;
    int fuerza;
    public GameObject gameOver;
    public SpriteRenderer colorDino;

	// Use this for initialization
	void Start () {

        fuerza = 15;
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * fuerza;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }

    private void OnDestroy()
    {
        Time.timeScale = 0f;
        gameOver.SetActive(true);
    }
}
