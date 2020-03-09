using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    static public GameObject[] Slots;
    public int ile_slotow=7;
    static private int ile_w_ekwipunku = 0;
    void Start()
    {
        Slots = new GameObject[ile_slotow];
        for(int i=0; i<ile_slotow; i++)
        {
            Slots[i] = null;
        }
    }
    static public void Equip(GameObject lol)
    {
        Slots[ile_w_ekwipunku] = lol;
        ile_w_ekwipunku++;
    }
}
