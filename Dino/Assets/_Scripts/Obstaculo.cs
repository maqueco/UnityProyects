using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {

    public float velocidad;

	// Use this for initialization
	void Start () {

        velocidad = 0.1f;
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(-velocidad, 0, 0);
	}

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
