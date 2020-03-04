using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

    public Text textoPuntos;
    public static float contador;

	// Use this for initialization
	void Start () {
        contador = 0;	
	}
	
	// Update is called once per frame
	void Update () {
        //contador = contador + 1;
        contador = contador + Time.deltaTime * 100;
        textoPuntos.text = contador.ToString("00000");
	}
}
