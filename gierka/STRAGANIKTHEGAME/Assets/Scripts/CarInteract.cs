using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInteract : MonoBehaviour
{
    public GameObject car;
    public Vector3 offset;
    public bool insideCar;
    

    void Start()
    {
        insideCar = false;
    }

    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.F) /*&& Vector3.Distance(transform.position, car.transform.position) < 100*/)
            {
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
        
    }
    

    private void inCar()
    {
        transform.position = car.transform.position + offset;
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
