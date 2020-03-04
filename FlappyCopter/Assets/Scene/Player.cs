using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	void Start () {
		
	}

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D myRigidbody = GetComponent<Rigidbody2D>();
            myRigidbody.velocity = new Vector2(0, 0);
            myRigidbody.AddForce(new Vector2(0, 300));
        }
        if (transform.position.y > 4.8f)
        {
            Die();
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
            Die();
    }
    void Die() {
            Application.LoadLevel(Application.loadedLevel);
    }
}
