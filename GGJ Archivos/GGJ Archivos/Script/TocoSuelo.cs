using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocoSuelo : MonoBehaviour
{
    private PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerController>();
    }

    void OnCollisionStay2D(Collision2D other) 
    {
        player.tocoSuelo = true;
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        player.tocoSuelo = false;    
    }
}
