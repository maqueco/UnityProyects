using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fundido : MonoBehaviour
{
    public Image fundido;
    public string[] escenas;
    public AudioSource audio;
    public AudioClip clip;
    public Text Creditos;
    public Text CreditosTitulo;
    // Start is called before the first frame update
    void Start()
    {
        fundido.CrossFadeAlpha(0,1f,false);
        audio.clip = clip;
        Creditos.CrossFadeAlpha(0,0.001f,false);
    }

    public void FadeOut(int s)
    {
        fundido.CrossFadeAlpha(1,0.7f,false);
        StartCoroutine(CambiosEscena(escenas[s]));
        
    }

    IEnumerator CambiosEscena(string escena)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(escena);
    }

    public void ReproducirClip()
    {
        audio.Play();
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salio el juego");
    }

    public void FadeOutCreditos()
    {
        CreditosTitulo.CrossFadeAlpha(1,0.1f,false);
        fundido.CrossFadeAlpha(1,0.5f,false);
        Creditos.CrossFadeAlpha(1,1f,false);
        StartCoroutine(EsperaCreditos());
    }

    IEnumerator EsperaCreditos()
    {
        yield return new WaitForSeconds(7f);
        CreditosTitulo.CrossFadeAlpha(0,0.001f,false);
        Creditos.CrossFadeAlpha(0,0.5f,false);
        fundido.CrossFadeAlpha(0,1f,false);
    }

}
