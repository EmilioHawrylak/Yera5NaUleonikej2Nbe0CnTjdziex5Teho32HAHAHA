using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public GameObject Item;
    public GameObject sprite; 
    public void on_Click()
    {
       if (Item != null)// jesli slot nie jest pusty 
        {
            sprite.SetActive(false);// wylacz podglad
            Item.transform.position = Interact.Hand_position;// pozycja reki gracza ustaw tam aby wyrzucic
            Item.SetActive(true);//na mapie 
            Item = null;//wyzeruj slot
            InventoryUI.full = false;// ekwipunek nie jest pelny
        }
    }
}
