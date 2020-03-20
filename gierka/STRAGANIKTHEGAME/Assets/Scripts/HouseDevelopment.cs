using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDevelopment : MonoBehaviour
{
    public int HouseLevel;
    public GameObject AdditionalBuilding;
    private bool BuildingCreated;
    public Transform HouseParent;
    public Rigidbody HouseRG;
    public bool OpenDevelopmentPanel;
    public GameObject LevelUpButton;
    public GameObject Background;
    public GameObject Title;
    public PlayerMovement Player;
    public bool canOpen;
    void Start()
    {
        HouseLevel = 1;
        BuildingCreated = false;
        OpenDevelopmentPanel = false;
        canOpen = false;
        LevelUpButton.SetActive(false);
        Background.SetActive(false);
        Title.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (HouseLevel)
        {
            case 1:
                break;

            case 2:
                if (!BuildingCreated)
                {
                    CreateAdditionalBuilding(AdditionalBuilding, HouseRG.position.x + 4f, HouseRG.position.y, HouseRG.position.z, HouseParent);
                }
                break;
        }
        if (canOpen)
            OpenDevelopmentPanel = true;
        else
            OpenDevelopmentPanel = false;
    }

    private void CreateAdditionalBuilding(GameObject Building, float PosX, float PosY, float PosZ, Transform Parent)
    {
        Instantiate(Building, new Vector3(PosX, PosY, PosZ) ,Quaternion.identity, Parent);
        BuildingCreated = true;
    }

    public void OpenDevPanel()
    {
        if (OpenDevelopmentPanel)
        {
            Background.SetActive(true);
            LevelUpButton.SetActive(true);
            Title.SetActive(true);
            Player.enabled = false;
        }else if (!OpenDevelopmentPanel){
            Background.SetActive(false);
            LevelUpButton.SetActive(false);
            Title.SetActive(false);
            Player.enabled = true;
        }
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
