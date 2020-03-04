using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject enemigoGO;
    public Transform enemigo = null;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 12;
        enemigo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemigoGO.SetActive(false);
        EnemigoPersigue();
    }

    // Update is called once per frame
    void Update()
    { 
        if(enemigo != null)
        {
            transform.position = Vector2.MoveTowards(transform.position,enemigo.transform.position, Speed * Time.deltaTime);

        }
    }

    void EnemigoPersigue()
    {
        StartCoroutine(EsperaEnemigo());
    }

    IEnumerator EsperaEnemigo()
    {
         yield return new WaitForSeconds(3);
         enemigoGO.SetActive(true);
    }
    
}
