using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Low()
    {
        QualitySettings.SetQualityLevel(1); 
        Debug.Log("Low");
    }
    public void Medium()
    {
        QualitySettings.SetQualityLevel(2);
        Debug.Log("Medium");
    }
    public void High()
    {
        QualitySettings.SetQualityLevel(3);
        Debug.Log("High");
    }
}
