using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
public GameObject obstacle;
public int score;

    void SpawnObstacles() {
         Instantiate(obstacle, transform.position, Quaternion.identity);
         score++;
         transform.Translate(new Vector3(0, Random.Range(-2, 3)));
    }

	void Start () { 
        InvokeRepeating("SpawnObstacles", 1f, 2.5f);       
	}

	void Update () {
		
	}

    void OnGUI() {
        GUI.color = Color.black;
        GUILayout.Label("Score:" + score.ToString());
    }
}
