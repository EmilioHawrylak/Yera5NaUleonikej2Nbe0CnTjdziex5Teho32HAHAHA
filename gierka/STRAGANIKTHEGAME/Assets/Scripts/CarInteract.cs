using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInteract : MonoBehaviour
{
    public GameObject car;
    public Transform sittingLoc;
    public Vector3 offset;
    public bool insideCar;
    public GameObject text;


    void Start()
    {
        insideCar = false;
    }

    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.F) && Vector3.Distance(transform.position, car.transform.position) < 3)
            {
                if(insideCar)
                {
                    transform.position = car.transform.position + offset;
                }
                insideCar = !insideCar;
            }
            if (insideCar)
            {
                inCar();
            }
            else
            {
                outCar();
            }

            if(!insideCar && Vector3.Distance(transform.position, car.transform.position) < 3)
            {
                text.SetActive(true);
            }
            else
            {
                text.SetActive(false);
            }
        
    }
    

    private void inCar()
    {
        transform.position = sittingLoc.position;
        //transform.rotation = car.transform.rotation;
        car.GetComponent<CarScript>().enabled = true;
        GetComponent<CharacterController>().enabled = false;
    }
    private void outCar()
    {
        car.GetComponent<CarScript>().enabled = false;
        insideCar = false;
        GetComponent<CharacterController>().enabled = true;
    }
}
