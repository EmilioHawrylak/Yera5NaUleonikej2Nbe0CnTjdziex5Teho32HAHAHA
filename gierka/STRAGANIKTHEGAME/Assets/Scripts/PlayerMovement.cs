﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterControler;
    public float movementSpeed = 7.0f;
    public float jumpHeight = 7.0f;
    public float currentJumpHeight = 0f;
    public float runningSpeed = 14.0f;

    public float mouseSensitivity = 3.0f;
    public float mouseUpDown = 0.0f;
    public float mouseUpDownRange = 90.0f;
    
    public PlayerStats Stats;
    public GameObject Eq;
    public GameObject TraderMenu;

    private void Start()
    {
        characterControler = GetComponent<CharacterController>();
        Eq.SetActive(false);
    }

    private void Update()
    {
        if (PlayerStats.active_ui == false && !Eq.activeInHierarchy && !TraderMenu.activeInHierarchy)
        {
            keyboard();
            mouse();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (Eq.activeInHierarchy)
            {
                Eq.SetActive(false);
            }
            else if (!Eq.activeInHierarchy)
            {
                Eq.SetActive(true);
            }
        }
    }

    private void keyboard()
    {

        float movementFrontBack = Input.GetAxis("Vertical") * movementSpeed;

        float movementLeftRight = Input.GetAxis("Horizontal") * movementSpeed;



        if (characterControler.isGrounded && Input.GetButton("Jump"))
        {
            currentJumpHeight = jumpHeight;
        }
        else if (!characterControler.isGrounded)
        {

            currentJumpHeight += Physics.gravity.y * Time.deltaTime;
        }

        //Debug.Log (Physics.gravity.y);



        if (Input.GetKey("left shift") && Stats.Stamina > 1.0)
        {
            movementSpeed = runningSpeed;
            Stats.Sprint = true;
        }
        else
        {
            movementSpeed = 7.0f;
            Stats.Sprint = false;
        }

        Vector3 movement = new Vector3(movementLeftRight, currentJumpHeight, movementFrontBack);

        movement = transform.rotation * movement;
        characterControler.Move(movement * Time.deltaTime);

    }
    private void mouse()
    {

        float mouseLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, mouseLeftRight, 0);


        mouseUpDown -= Input.GetAxis("Mouse Y") * mouseSensitivity;


        mouseUpDown = Mathf.Clamp(mouseUpDown, -mouseUpDownRange, mouseUpDownRange);

        Camera.main.transform.localRotation = Quaternion.Euler(mouseUpDown, 0, 0);
    }
}
