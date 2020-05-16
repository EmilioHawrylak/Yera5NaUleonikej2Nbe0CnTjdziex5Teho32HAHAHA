using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleep : MonoBehaviour
{
    public GameObject sun;
    public GameObject defeaultSunPos;
    public bool inTrigger=false;
    void Start()
    {
        
    }


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inTrigger = false;
        }
    }

    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                sun.transform.rotation = defeaultSunPos.transform.rotation;
                Debug.Log("sleep");
            }
        }
    }
}
