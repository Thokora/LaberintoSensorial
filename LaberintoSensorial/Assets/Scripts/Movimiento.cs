﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    /* Animator animator;

     private float verticalVelocity;
     //public Transform lookAtTarget;
     public float gravity = 20.0f;
     public float jumpForce = 10.0f;
     public float gravityToRun = 0.3f;

     public float rotationSpeed = 1.0f;
     private float rot = 0.0f;
     private bool run = false;
     private bool shooting = false;
     public GameObject effectoBala;*/
    public GameObject player;
    CharacterController controller;
    float CaminarValor;
    public float Velocity = 3f;
    public float RunVelocity = 10f;
    float MoveV;
    float MoveH;

    void Start()
    {

        controller = player.GetComponent<CharacterController>();
        /*animator = GetComponent<Animator>();
        nikolai = GameObject.Find("Nikolai");
        shooting = false;*/

    }

    void Update()
    {
        MoveV = Input.GetAxis("Horizontal"); //Se coloca horizontal para que quede dereho en el control
        controller.transform.Translate(Vector3.forward * (MoveV * CaminarValor) * Time.deltaTime);

        MoveH = Input.GetAxis("Vertical"); //Se coloca Vertical para que quede dereho en el control
        controller.transform.Translate(Vector3.right * (MoveH * CaminarValor) * Time.deltaTime);

        if (Input.GetButton("Fire1"))
        { //correr D
            CaminarValor = RunVelocity;
        }
        else
        {
            CaminarValor = Velocity;
        }
        /*if (v > 0.1f)
        {

        }
        else
        {

        }

        //nikolai.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);

        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);

        if (controller.isGrounded)
        {
            //saltar
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetButtonDown("Jump"))
            {//A y Arriba
                verticalVelocity = jumpForce;
                animator.SetBool("saltar", true);
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
            animator.SetBool("saltar", false);
        }
        if (Input.GetButton("Fire1"))
        {//disparar B y Abajo
            animator.SetBool("disparar", true);
            shooting = true;
            if (shooting == true)
            {
                effectoBala.SetActive(true);
            }
        }
        else
        {
            animator.SetBool("disparar", false);
            shooting = false;
            if (shooting == false)
            {
                effectoBala.SetActive(false);
            }
        }
        
        if (Input.GetButton("Fire3"))
        {//C

        }
        if (Input.GetKey("up"))
        {
            controller.transform.Translate(Vector3.forward * RunVelocity * Time.deltaTime);
            animator.SetBool("correr", true);
        }
        else
        {
            animator.SetBool("correr", false);
        }


        if (run == true)
        {
            //Vector3 corriendo = new Vector3(0, 0, RunVelocity); // solo va hacia adelante pero no gira cuando la camara lo hace
            controller.transform.Translate(Vector3.forward * RunVelocity * Time.deltaTime);
            StartCoroutine(Esperar());
        }
        //rotaciones
        rot += Input.GetAxis("Horizontal") * rotationSpeed;
        transform.eulerAngles = new Vector3(0.0f, rot, 0.0f);

        //transform.LookAt(lookAtTarget);
        //transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        // transform.LookAt(lookAtTarget);
        //nikolai.transform.LookAt(new Vector3(lookAtTarget.position.x, transform.position.y, lookAtTarget.position.z));
        */
    }

    /*IEnumerator Esperar()
    {
        yield return new WaitForSeconds(2f);
        if ((Input.acceleration.x < 0.3f && Input.acceleration.x > -0.3))
        {
            animator.SetBool("correr", false);
            run = false;
            //animator.SetBool("saltar", false);
        }
    }*/
}
