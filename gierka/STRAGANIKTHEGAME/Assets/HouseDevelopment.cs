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
    void Start()
    {
        HouseLevel = 1;
        BuildingCreated = false;
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
                    CreateAdditionalBuilding(AdditionalBuilding, HouseRG.position.x + 1.5f, HouseRG.position.y, HouseRG.position.z, HouseParent);
                }
                break;
        }
    }

    private void CreateAdditionalBuilding(GameObject Building, float PosX, float PosY, float PosZ, Transform Parent)
    {
        Instantiate(Building, new Vector3(PosX, PosY, PosZ) ,Quaternion.identity, Parent);
        BuildingCreated = true;
    }
}
