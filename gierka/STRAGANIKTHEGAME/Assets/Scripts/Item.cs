﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName ="Inventory")]
public class Item : ScriptableObject
{
    new public string name = "Item";
    public Sprite icon = null;
    public bool isDeafaultItem = false;

    public virtual void Use()
    {
        Debug.Log("Use");
    }
}
