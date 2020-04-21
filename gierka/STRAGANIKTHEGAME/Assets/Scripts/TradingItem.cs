using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradingItem : MonoBehaviour
{
    public Image ItemIcon;
    public string ItemName;
    public float Cost;
    public GameObject Item;
    public Text Description;

    void Start()
    {
        
    }

    void Update()
    {
        Description.text = ItemName + "\n" + Cost.ToString() + "$";   
    }
}
