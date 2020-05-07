using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interact : MonoBehaviour
{
    public GameObject Text_interact;
    public GameObject Hand;
    static public Vector3 Hand_position;
    public GameObject Text_full;
    public GameObject launch_inv;
    public GameObject launch_chest;
    private float time=0;
    private float delay=3;

    bool able_to_pick = false;
    bool able_to_open_storage = false;
    static public bool in_storage = false;
    static public GameObject Item_to_pick_up;
    void OnCollisionEnter(Collision Item_object)
    {
        if(Item_object.gameObject.tag == "Item")
        {
            Text_interact.SetActive(true);
            able_to_pick = true;
            Item_to_pick_up = Item_object.gameObject; 
        }
        else if(Item_object.gameObject.tag == "Chest")
        {
            Text_interact.SetActive(true);
            able_to_pick = true;
            able_to_open_storage = true;
        }
    }
    void OnCollisionExit()
    {
        Text_interact.SetActive(false);
        able_to_pick = false;
    }
    void Update()
    {
        launch_eq();

        if (able_to_pick == true && Input.GetKeyDown(KeyCode.F) == true && InventoryUI.full == false && able_to_open_storage==false)
        {
             InventoryUI.Equip(Item_to_pick_up);
             Item_to_pick_up.SetActive(false);
             Text_interact.SetActive(false);
             able_to_pick = false;
        }
        else if(able_to_pick == true && Input.GetKeyDown(KeyCode.F)&& able_to_open_storage == true )
        {
            launch_chest.SetActive(true);
            in_storage = true;
            able_to_open_storage = false;
        }


        /************************************************************************/
        Equipment_is_full_wait();// jesli ekwipunek pelen to wyswietl tekst i po 3 sekundach go wylacz 
        /*************************************************************************/// jesli pelen
        Hand_position = Hand.GetComponent<Transform>().position;

    }
    void Start()
    {
        Debug.Log("start");
    }
    private void Equipment_is_full_wait()
    {
        time += Time.deltaTime;
        if (InventoryUI.full == true && Input.GetKeyDown(KeyCode.F) == true && able_to_pick  == true)
        {
            Text_full.SetActive(true);
        }
        if (time >= delay)
        {
            Text_full.SetActive(false);
            time = 0;
        }
    }
    private void launch_eq()
    {
        if (launch_inv.active == false && Input.GetKeyDown(KeyCode.B))
        {
            InventoryUI.active = true;
            launch_inv.SetActive(true);
        }
        else if (launch_inv.active == true && Input.GetKeyDown(KeyCode.B))
        {
            InventoryUI.active = false;
            launch_inv.SetActive(false);
        }
    }

}
