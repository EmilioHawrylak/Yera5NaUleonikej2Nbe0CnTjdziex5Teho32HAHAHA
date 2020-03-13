using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform follow;
    public Vector3 offset;
    void Update()
    {
        transform.position = follow.position + offset;
    }
}
