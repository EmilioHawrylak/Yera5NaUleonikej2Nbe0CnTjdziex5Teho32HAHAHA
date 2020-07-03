using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trader : MonoBehaviour
{
    public PlayerStats Stats;
    public GameObject TraderPanel;
    public PlayerMovement Player;
    public Text Money;
    public TradingItem Item;
    public bool canOpen;
    public NewEq Inventory;

    void Start()
    {
        TraderPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Money.text = "You have " + Stats.Money.ToString() + "$.";
        if (Input.GetKeyDown(KeyCode.T) && canOpen)
        {
            if (TraderPanel.activeInHierarchy)
            {
                TraderPanel.SetActive(false);
            }
            else if (!TraderPanel.activeInHierarchy)
            {
                TraderPanel.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            canOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            canOpen = false;
        }
    }
}
