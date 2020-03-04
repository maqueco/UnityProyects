using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {
	void Start () {
		
	}	
	void Update () {
        transform.Translate(Vector3.left * 2 * Time.deltaTime);
        if (transform.position.x < -14.5) {
            DestroyObject(gameObject);
        }
	}
}
