using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour {

	public Color color;

	// Update is called once per frame
	void Update () {
		if (Contador.contador >= 1000 && Contador.contador <= 2000)
        {
            Camera.main.backgroundColor = Color.black;
        }
        else
        {
            Camera.main.backgroundColor = Color.white;
        }
	}
}
