using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float HealthPoints, Hunger, Stamina, Thirst, Money;
    public int XP;
    public bool Sprint;

    void Start()
    {
        HealthPoints = 100;
        Hunger = 100;
        Stamina = 100;
        Thirst = 100;
        XP = 20;
        Money = 100;
    }

    void Update()
    {
        HungerGrowth();
        ThirstGrowth();
        StaminaFalling();
        
        
    }

    private void HungerGrowth()
    {
        if(Hunger > 0)
            Hunger -= Time.deltaTime / 6;
    }

    private void ThirstGrowth()
    {
        if (Thirst > 0)
            Thirst -= Time.deltaTime / 3;
    }

    public void StaminaFalling()
    {
        if (Sprint)
        {
            Stamina -= Time.deltaTime * 2;
        }
    }
    public void addXP(int xpquantity)
    {
        XP = XP + xpquantity;
    }
}
