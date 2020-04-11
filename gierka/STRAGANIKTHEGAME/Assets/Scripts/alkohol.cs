using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alkohol : MonoBehaviour
{
    public bool inTrigger;
    public bool drunk=false;

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Beer")
        {
            inTrigger = true;
            OnGUI();
            Debug.Log("Pijesz");
        }
        if (collision.gameObject.name == "Wodka")
        {
            inTrigger = true;
            Debug.Log("Pijesz");
        }
        if (collision.gameObject.name == "Whisky")
        {
            inTrigger = true;
            Debug.Log("Pijesz");
        }
        if (collision.gameObject.name == "Spirytuss")
        {
            inTrigger = true;
            Debug.Log("Pijesz");
        }
       
    }
    void OnTriggerExit(Collider collision)
    {
        inTrigger = false;
    }


    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(700, 450, 200, 25), "Press E to drink");
        }
    }
}
