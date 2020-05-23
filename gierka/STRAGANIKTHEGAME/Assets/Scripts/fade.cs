using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        
        
        yield return new WaitForSeconds(1);
        Destroy(gameObject);

        
    }
}