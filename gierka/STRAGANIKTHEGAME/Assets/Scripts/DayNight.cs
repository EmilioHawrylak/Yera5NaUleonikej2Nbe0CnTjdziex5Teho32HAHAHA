using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public float speed = 1;
    float mn;

    
    void Update()
    {
        mn = speed * Time.deltaTime;
        transform.Rotate(Vector3.right*mn);
    }
}
