using UnityEngine;

public class NewInventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    NewEq Inventory;
    EqSlot[] slots;
    // Start is called before the first frame update
    void Start()
    {
        Inventory = NewEq.instance;
        Inventory.onItemCHangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<EqSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(i< Inventory.items.Count)
            {
                slots[i].AddItem(Inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
