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
    float avgRPM;
    //public Transform camera;
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
        avgRPM = Mathf.Lerp(0.5f, 2, ((FL.rpm + FR.rpm + RL.rpm + RR.rpm) / 4) / 300);
        if (FR.steerAngle > 45)
        {
            FL.steerAngle = 45;
            FR.steerAngle = 45;
        } else if(FR.steerAngle < -45)
        {
            FL.steerAngle = -45;
            FR.steerAngle = -45;
        }else{
            FL.steerAngle += Input.GetAxisRaw("Horizontal") * steerSens / avgRPM;
            FR.steerAngle += Input.GetAxisRaw("Horizontal") * steerSens / avgRPM;
        }
        if(isInterior)
        {
            //camera.position = chaseCam.position;
            //camera.rotation = chaseCam.rotation;
        } else{
            //camera.position = interiorCam.position;
            //camera.rotation = interiorCam.rotation;
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            isInterior = !isInterior;
        }
        //Debug.Log(avgRPM);
    }
}
