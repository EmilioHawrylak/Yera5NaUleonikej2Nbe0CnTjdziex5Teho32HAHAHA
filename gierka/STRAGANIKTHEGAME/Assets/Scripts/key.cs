using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key: MonoBehaviour
{
    public bool inTrigger;

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
                DoorScript.doorKey = true;
                Destroy(this.gameObject);
            }
        }
    }

    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(700, 450, 200, 25), "Press E to take key");
        }
    }
    /* public GameObject Drzwi;
     // Start is called before the first frame update
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {

     }
     private void OnTriggerEnter(Collider col)
     {
         if (col.tag == "gracz")
         {
             Drzwi.GetComponent<Drzwi>().KluczZebrany = true;
             Destroy(gameObject);
         }
     }*/
}
