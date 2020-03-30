using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("nextScene", 5);
    }

    // Update is called once per frame
    void nextScene()
    {
        Application.LoadLevel("test3");
    }
}
