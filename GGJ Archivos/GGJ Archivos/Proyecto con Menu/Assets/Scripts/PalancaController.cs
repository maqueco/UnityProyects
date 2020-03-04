using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalancaController : MonoBehaviour
{
    public Animator animPalanca;   
    public float vert;
    public bool palanca = false;
    // Start is called before the first frame update
    void Start()
    {
        animPalanca = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.rotation = new Vector3 (0, 0, 0);
    }

    void OnMouseDown() 
    {
        switch (palanca)
        {
            case true:
                animPalanca.SetBool("On",false);
                palanca = false;
            break;
            case false:
                animPalanca.SetBool("On",true);
                palanca = true;
            break;
        }
    }
/*
    

    void OnMouseUp() {
        PalancaDesactivada();
    }

    IEnumerator PalancaDesactivada()
    {
        animPalanca.SetFloat("PalanzaOn",0);
        yield return new WaitForSeconds(1);  
        animPalanca.enabled = false; 
    }

*/
}
