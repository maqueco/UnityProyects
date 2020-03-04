using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_plataforma : MonoBehaviour
{
    public Animator animator;
    public float boton;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {/*
        boton = Input.GetAxis("Vertical");
        if(boton != 0)
        {
            animator.enabled = false;
        }
        else
        {
          animator.enabled = true;  
        }
        */
    }

}
