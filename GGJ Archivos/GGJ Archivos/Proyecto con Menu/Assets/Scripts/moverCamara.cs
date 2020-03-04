using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverCamara : MonoBehaviour
{

    public Vector3 offset;
    public GameObject objetivo;
    public float desplazamiento = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = objetivo.transform.position;
        pos.z = -10;
        transform.position = Vector3.Lerp(transform.position, pos + offset, desplazamiento);
    }
}
