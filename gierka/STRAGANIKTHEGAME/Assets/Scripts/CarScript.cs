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
        Debug.Log(FR.steerAngle);
    }
}
