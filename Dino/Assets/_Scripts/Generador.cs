using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

    public GameObject[] prefab;
    float tiempoRandom;
    int id;
    float velocidadIncrementa1;
    Obstaculo obstaculo;

	// Use this for initialization
	void Start () {

        velocidadIncrementa1 = 0.05f;
        Generar();
    }
	
	// Update is called once per frame
	void Generar () {

        id = Random.Range(0, prefab.Length);

        GameObject clon = Instantiate(prefab[id]);

        obstaculo = clon.GetComponent<Obstaculo>();

        velocidadIncrementa1 += 0.01f;

        obstaculo.velocidad += velocidadIncrementa1;

        tiempoRandom = Random.Range(2.5f, 5f);

        Invoke("Generar", tiempoRandom);
	}
}
