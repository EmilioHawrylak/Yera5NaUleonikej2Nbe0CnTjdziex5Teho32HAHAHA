using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEq : MonoBehaviour
{
    #region Singleton
    public static NewEq instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Za duzo eq(czy cos takiego)");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemCHangedCallback;

    public int space = 2;
    public List<Item> items = new List<Item>();

    public bool Add(Item item)
    {
        if (!item.isDeafaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("nie ma miejsca");
                return false;
            }
            items.Add(item);

            if (onItemCHangedCallback != null)
            {
                onItemCHangedCallback.Invoke();
            }
        }
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemCHangedCallback != null)
        {
            onItemCHangedCallback.Invoke();
        }
    }
}
