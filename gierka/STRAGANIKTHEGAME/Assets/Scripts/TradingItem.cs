using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradingItem : Interactable
{
    public Item item;

    public float Cost;
    public Text Description;
    public Button BuyButton;

    void Start()
    {
        
    }

    void Update()
    {
        Description.text = item.name + "\n" + Cost.ToString() + "$";   
    }

    public override void Interact()
    {
        base.Interact();

        Sell();
    }

    public void Sell()
    {
        bool bought = NewEq.instance.Add(item);
        if (bought)
            Destroy(gameObject);
    }
}
