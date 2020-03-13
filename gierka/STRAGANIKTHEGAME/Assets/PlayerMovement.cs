using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterControler;
    public Camera cam;
    public GameObject inventory;
    public float movementSpeed = 4.0f;
    public float jumpHeight = 1.0f;
    public float currentJumpHeight = 0f;
    public float runningSpeed = 7.0f;

    public float mouseSensitivity = 3.0f;
    public float mouseUpDown = 0.0f;
    public float mouseUpDownRange = 90.0f;
    public float test;

    void Start()
    {
        characterControler = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        keyboard();
        mouse();
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

        if (Input.GetKey("left shift"))
        {
            movementSpeed = runningSpeed;
        }
        else
        {
            movementSpeed = 4.0f;
        }

        Vector3 movement = new Vector3(movementLeftRight, currentJumpHeight, movementFrontBack);

        movement = transform.rotation * movement;
        if (inventory.active == false)
        {
            characterControler.Move(movement * Time.deltaTime);
        }
        //////////////////////////////
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inventory.active == false)
            {
                inventory.SetActive(true);
            }
            else { inventory.SetActive(false); }
        }
    }

    private void mouse()
    {
        if (inventory.active == false)
        {
            float mouseLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
            transform.Rotate(0, mouseLeftRight, 0);
            float mouseUpDown = Input.GetAxis("Mouse Y") * mouseSensitivity;
            cam.transform.Rotate(-mouseUpDown, 0, 0);
        }

       /* mouseUpDown -= Input.GetAxis("Mouse Y") * mouseSensitivity;


        mouseUpDown = Mathf.Clamp(mouseUpDown, -mouseUpDownRange, mouseUpDownRange);

       // Camera.main.transform.localRotation = Quaternion.Euler(mouseUpDown, 0, 0);\
       */
    }
}

//Bartek A. skrypt wzięty z poruszania się w forgotten
//Staminę dodam później
