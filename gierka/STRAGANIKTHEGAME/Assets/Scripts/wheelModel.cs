using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelModel : MonoBehaviour
{
    public WheelCollider wheelC;
    private Vector3 pos;
    private Quaternion quat;
    public Vector3 offset;
    public Transform Car;
    int orientation;

    void Start()
    {
        orientation = 1;
        if(wheelC.tag == "left")
        {
            orientation = -1;
        }
    }
    void FixedUpdate()
    {
        wheelC.GetWorldPose(out pos, out quat);
        transform.position = pos + offset;
        transform.Rotate(0, 0, -wheelC.rpm / 60 * 360 * Time.deltaTime);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 90 * orientation + wheelC.steerAngle, transform.localEulerAngles.z);
    }
}
