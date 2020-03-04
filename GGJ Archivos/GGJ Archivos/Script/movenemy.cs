using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{


    public GameObject enemigoGO;
    public float px;
    public float py;
    bool rebota = false;

    // Start is called before the first frame update
    void Start()
    {

        enemigoGO.SetActive(true);
        EnemigoPersigue();


    }

    // Update is called once per frame
    void Update()
    {
        if (rebota == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + px, gameObject.transform.position.y + py, gameObject.transform.position.z);
        }

        if (rebota == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - px, gameObject.transform.position.y - py, gameObject.transform.position.z);

        }

    }

    void EnemigoPersigue()
    {
        StartCoroutine(EsperaEnemigo());
    }

    IEnumerator EsperaEnemigo()
    {
        yield return new WaitForSeconds(3);
        enemigoGO.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Pared")
        {
            rebota = true;
        }
    }

    //private void OnDestroy()
    //{
    //    Time.timeScale = 0f;
    //    gameOver.SetActive(true);
    //}

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
