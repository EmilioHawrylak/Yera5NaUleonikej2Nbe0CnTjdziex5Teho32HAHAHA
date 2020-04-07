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
    public bool canOpen;

    void Start()
    {
        TraderPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T) && canOpen)
        {
            Debug.Log("T pressed");
            if (TraderPanel.activeInHierarchy)
            {
                TraderPanel.SetActive(false);
                Player.enabled = true;
            }
            else
            {
                TraderPanel.SetActive(true);
                Player.enabled = false;
            }
        }

        Money.text = "You have " + Stats.Money.ToString() + "$.";
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
