﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour{

    public GameObject linkedDoor;
    public bool isUnlocked;

    private Animator animator;
    private GameObject error;
    private GameObject validate;

    private void Start(){

        animator = GetComponent<Animator>();
        error = transform.GetChild(0).gameObject;
        validate = transform.GetChild(0).gameObject;

    }

    private void OnMouseDown(){
        
        if (isUnlocked){

            animator.SetTrigger("Validate");
            error.SetActive(false);
            validate.SetActive(true);
            // Play green animation and open the gate.

        }

        else{

            animator.SetTrigger("Error");
            validate.SetActive(false);
            error.SetActive(true);
            // Play red animation

        }

    }

}