using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradingItem : MonoBehaviour
{
    public Item item;

    public float Cost;
    public Text Description;

    void Start()
    {
        
    }

    void Update()
    {
        Description.text = item.name + "\n" + Cost.ToString() + "$";   
    }
}
