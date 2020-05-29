using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public float fillAmount;
    public Image barImage;

    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Value = 10;
    }

    // Update is called once per frame
    void Update()
    {
        HandleBar();
    }

    public void HandleBar()
    {   
        barImage.fillAmount = fillAmount;
    }

    public float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
