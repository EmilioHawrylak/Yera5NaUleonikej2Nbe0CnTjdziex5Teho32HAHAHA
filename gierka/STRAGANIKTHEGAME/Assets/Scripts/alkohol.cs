using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class alkohol : MonoBehaviour
{
    public bool InTrigger=false;
    public  float drunkTimer = 0;
    public float beerTimer = 35;
    public float wodkaTimer = 120;
    public float whiskyTimer = 360;

    bool InTriggerBeer = false;
    bool InTriggerWodka = false;
    bool InTriggerWhisky = false;

    void Start()
    {
        
    }
    void Update()
    {
        alkohole();

        drunkTimer -= Time.deltaTime;
        Debug.Log(drunkTimer);
        while (drunkTimer < 0)
        {
            drunkTimer = 0;
        }
            
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Beer")
        {
            InTriggerBeer = true;
        }
        if (collision.gameObject.name == "Wodka")
        {
            InTriggerBeer = true;
        }
        if (collision.gameObject.name == "Whisky")
        {
            InTriggerBeer = true;
        }
    }
    public void alkohole()
    {
        if (InTriggerBeer)
        {
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    drunkTimer = drunkTimer + beerTimer;
                }
            }
        }
        if (InTriggerWodka)
        {
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    drunkTimer = drunkTimer + wodkaTimer;
                }
            }
        }
        if (InTriggerWhisky)
        {
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    drunkTimer = drunkTimer + whiskyTimer;
                }
            }
        }
    }

    /*
    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(700, 450, 200, 25), "Press E to drink");
        }
    }

    */
}
