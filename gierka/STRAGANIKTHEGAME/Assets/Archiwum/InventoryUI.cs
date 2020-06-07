using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject Inventory_panel;
    static public InventorySlot[] Items;
    static private int ile_obiektow = 0;
    static public bool full = false;
    static public bool active = false; 
    void Start()
    {
        Items = GetComponentsInChildren<InventorySlot>();
        ile_obiektow = Items.Length;
        Debug.Log(ile_obiektow);
        Inventory_panel.SetActive(active);
    }
    public static void Equip(GameObject Object_to_equip)// algorytm na dodawanie obiektow
    {
        int count=0;
        for (int i = 0; i < ile_obiektow; i++)
        {
            if (Items[i].Item != null)
            {
                count++;
            }
        }
        for(int i=0; i<ile_obiektow; i++)
        {
            if (Items[i].Item == null&&full==false)
            {
                Items[i].Item = Object_to_equip;
                Items[i].sprite.SetActive(true); 
                Object_to_equip.SetActive(false);
                break;
            }
        }
        if (count == ile_obiektow - 1)
        {
            full = true;
        }
    }
}
