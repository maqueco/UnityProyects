using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activacion_Plataforma : MonoBehaviour
{
    public Controller_plataforma controller;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator.enabled = false ;
        controller.animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        animator.enabled = true;
        controller.animator.speed = 1;
        controller.animator.enabled = true;
    }

    private void OnMouseUp() 
    {
        animator.enabled = false ;
        controller.animator.enabled = false;

    }
}
