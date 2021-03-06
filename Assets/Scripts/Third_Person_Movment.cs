﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_Person_Movment : MonoBehaviour
{

    public CharacterController control;
    public Transform cam;

    public float speed = 6f;
    public float smoothing = 0.1f; //To smoothen transition when changing directions
    public float gravity = -9.8f;
    public float groundDist = 0.4f;
    
    public Transform groundCheck;
    public LayerMask groundMask;
    float turnSmoothVelocity;
   
    Vector3 gravVelocity;
    bool isGrounded;
    

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);
        if (isGrounded && gravVelocity.y < 0) 
        {
            gravVelocity.y = -2f;

        }
        gravVelocity.y += gravity * Time.deltaTime;
        control.Move(gravVelocity * Time.deltaTime);

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, smoothing);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            
            control.Move(moveDir.normalized * speed * Time.deltaTime);

           gravVelocity.y += gravity * Time.deltaTime;
            //control.Move(gravVelocity * Time.deltaTime);
        }
    }
}
