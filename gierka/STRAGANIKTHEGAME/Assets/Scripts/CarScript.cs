using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public WheelCollider FL;
    public WheelCollider FR;
    public WheelCollider RL;
    public WheelCollider RR;
    public float RPM = 10;
    public float steerSens;
    public Transform camera;
    public bool isInterior;
    public Transform interiorCam;
    public Transform chaseCam;

    void Start()
    {
        isInterior = true;
    }
    void Update()
    {
        RL.motorTorque = RPM * Input.GetAxisRaw("Vertical");
        RR.motorTorque = RPM * Input.GetAxisRaw("Vertical");
        if(FR.steerAngle > 45)
        {
            FL.steerAngle = 45;
            FR.steerAngle = 45;
        } else if(FR.steerAngle < -45)
        {
            FL.steerAngle = -45;
            FR.steerAngle = -45;
        }else{
            FL.steerAngle += Input.GetAxisRaw("Horizontal") * steerSens;
            FR.steerAngle += Input.GetAxisRaw("Horizontal") * steerSens;
        }
        if(isInterior)
        {
            camera.position = chaseCam.position;
            camera.rotation = chaseCam.rotation;
        } else{
            camera.position = interiorCam.position;
            camera.rotation = interiorCam.rotation;
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            isInterior = !isInterior;
        }
        Debug.Log(FR.steerAngle);
        Debug.Log(RR.rpm);
    }
}
