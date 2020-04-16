using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseDevelopment : MonoBehaviour
{
    public int HouseLevel;
    public GameObject AdditionalBuilding;
    public GameObject AdditionalBuilding2;
    private bool BuildingCreated;
    private bool Building2Created;
    public Transform HouseParent;
    public Rigidbody HouseRG;
    public PlayerMovement Player;
    public GameObject HDpanel;
    public bool canOpen;
    public Text canUpgrade;
    public Text XPShow;
    public PlayerStats Stats;
    public int XPNeeded;
  
    void Start()
    {
        HouseLevel = 1;
        BuildingCreated = false;
        canOpen = false;
        HDpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (HouseLevel)
        {
            case 1:
                XPNeeded = 10;
                break;

            case 2:
                if (!BuildingCreated && Stats.XP >= XPNeeded)
                {
                    CreateAdditionalBuilding(AdditionalBuilding, HouseRG.position.x + 2.8f, HouseRG.position.y + 2f, HouseRG.position.z - 1f, HouseParent);
                    BuildingCreated = true;
                }
                XPNeeded = 20;
                break;
            case 3:
                if (!Building2Created && Stats.XP >= XPNeeded)
                {
                    CreateAdditionalBuilding(AdditionalBuilding2, HouseRG.position.x, HouseRG.position.y + 2.5f, HouseRG.position.z, HouseParent);
                    Building2Created = true;
                }
                XPNeeded = 30;
                break;
                   
        }

        if (Input.GetKeyDown(KeyCode.Q) && canOpen)
        {
            Debug.Log("Q pressed");
            if(HDpanel.activeInHierarchy)
            {
                HDpanel.SetActive(false);
                Player.enabled = true;
            }
            else
            {
                HDpanel.SetActive(true);
                Player.enabled = false;
            }
        }
        if (Stats.XP >= XPNeeded)
            canUpgrade.text = "You can upgrade your house!";
        else
            canUpgrade.text = "Not enough XP to upgrade your house";

        XPShow.text = "XP : " + Stats.XP.ToString();
    }

    private void CreateAdditionalBuilding(GameObject Building, float PosX, float PosY, float PosZ, Transform Parent)
    {
        Instantiate(Building, new Vector3(PosX, PosY, PosZ) ,Quaternion.identity, Parent);
    }

    public void LevelUp()
    {
        HouseLevel += 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player"){
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
