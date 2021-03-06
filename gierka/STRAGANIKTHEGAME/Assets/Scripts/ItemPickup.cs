﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Debug.Log("Picking up " + item.name);
            bool wasPicked = NewEq.instance.Add(item);
            if (wasPicked)
                Destroy(gameObject);
        }
    }
}
