using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleep : MonoBehaviour
{
    public GameObject sun;
    public bool InTrigger=false;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (InTrigger)
        {
            sun.transform.Rotate(2.15473f, 5.799893f, -4.843276f);
            Debug.Log("Sun rotate");
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "player")
        {
            InTrigger = true;
        }
        
    }
}
