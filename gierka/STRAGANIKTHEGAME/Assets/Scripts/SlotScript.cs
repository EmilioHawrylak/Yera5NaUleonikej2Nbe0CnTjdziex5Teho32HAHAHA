using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour
{
    static public bool isFilled;
    static public Image EqSlot;
    void Start()
    {
        isFilled = false;
    }

    void Update()
    {
        
    }

    static public void AddItemToSlot(Sprite ItemIcon)
    {
        EqSlot.sprite = ItemIcon;
    }
}
