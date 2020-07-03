using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradingItem : Interactable
{
    public Item TradeItem;
    public PlayerStats Stats;

    public float Cost;
    public Text Description;                                            

    void Start()
    {
        
    }

    void Update()
    {
        Description.text = TradeItem.name + "\n" + Cost.ToString() + "$";   
    }

    public override void Interact()
    {
        base.Interact();

        Sell();
    }

    public void Sell()
    {
        if (Stats.Money >= Cost) {
            Debug.Log(TradeItem.name + " selled.");
            bool bought = NewEq.instance.Add(TradeItem);
            if (bought)
            {
                Destroy(gameObject);
                Stats.Money -= Cost;
            }
        }
    }
}
