using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alkohol : MonoBehaviour
{
    public bool inTrigger;
    public bool drunk=false;
    //czasy
    public float drunkTime = 0.0f;
    public float BeerTime = 2.0f;

    //zmienne do alko
    public bool beerTrigger =false;
    public bool wodkaTrigger = false;
    public bool whiskyTrigger = false;
    //blic bool beerTrigger = false;


    void Update()
    {
        if (beerTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                drunkTime = drunkTime + BeerTime - Time.deltaTime;
            }
        }
        
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.name == "Beer") 
        {
            beerTrigger = true;         
        }
        if (collision.gameObject.name == "Beer")
        {
            wodkaTrigger = true;
        }
        if (collision.gameObject.name == "Beer")
        {
            whiskyTrigger = true;
        }

    }
    void OnTriggerExit(Collider collision)
    {
        beerTrigger = false;
        wodkaTrigger = false;
        whiskyTrigger = false;
    }


    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(700, 450, 200, 25), "Press E to drink");
        }
    }

    
}
