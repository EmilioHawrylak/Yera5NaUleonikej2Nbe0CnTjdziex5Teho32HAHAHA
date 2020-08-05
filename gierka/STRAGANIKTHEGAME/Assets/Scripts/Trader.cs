using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trader : MonoBehaviour
{
    public PlayerStats Stats;
    public GameObject TraderPanel;
    public GameObject SellPanel;
    public GameObject BuyPanel;
    public PlayerMovement Player;
    public Text Money;
    public TradingItem Item;
    public bool canOpen;
    public NewEq Inventory;
    public bool isBuying;
    public bool isSelling;

    void Start()
    {
        TraderPanel.SetActive(false);
        isBuying = true;
        isSelling = false;
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
        if (TraderPanel.activeInHierarchy)
        {
            if (isSelling)
            {
                BuyPanel.SetActive(false);
                SellPanel.SetActive(true);
            }
            if (isBuying)
            {
                BuyPanel.SetActive(true);
                SellPanel.SetActive(false);
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

    public void TurnSellPanel()
    {
        isBuying = false;
        isSelling = true;
    }

    public void TurnBuyPanel()
    {
        isSelling = false;
        isBuying = true;
    }
}
