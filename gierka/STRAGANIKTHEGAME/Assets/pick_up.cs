using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pick_up : MonoBehaviour
{
    public GameObject Text;
    public GameObject Hand;
    static public Vector3 Hand_position;
    public GameObject Text_full;
    private float time=0;
    private float delay=3;

    bool able_to_pick = false;
    static public GameObject Item_to_pick_up;
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
    }
    void Update()
    {
        if (able_to_pick == true && Input.GetKeyDown(KeyCode.F) == true && InventoryUI.full == false)
        {
            if (InventoryUI.full == false)
            {
                InventoryUI.Equip(Item_to_pick_up);
                Item_to_pick_up.SetActive(false);
                Text.SetActive(false);
                able_to_pick = false;
            }
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
        if (InventoryUI.full == true && Input.GetKeyDown(KeyCode.F) == true && able_to_pick == true)
        {
            Text_full.SetActive(true);
        }
        if (time >= delay)
        {
            Text_full.SetActive(false);
            time = 0;
        }
    }
}
