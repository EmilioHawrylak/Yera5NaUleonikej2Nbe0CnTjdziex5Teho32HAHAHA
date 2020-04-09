using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradingItem : MonoBehaviour
{
    public Image ItemIcon;
    public string ItemName;
    public float Price;
    public Text Description;

    void Start()
    {
        
    }

    void Update()
    {
        Description.text = ItemName + "\n" + Price.ToString() + "$";   
    }
}
