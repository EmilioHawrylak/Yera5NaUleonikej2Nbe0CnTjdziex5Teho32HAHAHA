using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pick_up : MonoBehaviour
{
    public GameObject Text;
    private bool able_to_pick = false;
    private GameObject Item_to_pick_up;
    void OnCollisionEnter(Collision Item_object)
    {
        if(Item_object.gameObject.tag == "Item")
        {
            Text.SetActive(true);
            able_to_pick = true;
            Item_to_pick_up = Item_object.gameObject;
        }
    }
    void OnCollisionExit()
    {
        Text.SetActive(false);
        able_to_pick = false;
        Item_to_pick_up = null; 
    }
    void Update()
    {
        if (able_to_pick==true && Input.GetKey(KeyCode.F)==true )
        {
            Equipment.Equip(Item_to_pick_up);
            Destroy(Item_to_pick_up);
            Text.SetActive(false);
        }
    }
}
