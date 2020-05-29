using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float HealthPoints, Hunger, Stamina, Thirst, Money;
    public float MaxHealthPoints, MaxHunger, MaxStamina, MaxThirst;
    public int XP;
    public bool Sprint;
    public Bar HealthBar;
    public Bar StaminaBar;
   
    void Start()
    {
        MaxHealthPoints = 100;
        MaxHunger = 100;
        MaxStamina = 100;
        MaxThirst = 100;
        XP = 20;
        Money = 100;
        HealthPoints = MaxHealthPoints;
        Hunger = MaxHunger;
        Stamina = MaxStamina;
        Thirst = MaxThirst;
        HealthBar.MaxValue = MaxHealthPoints;
    }

    void Update()
    {
        HungerGrowth();
        ThirstGrowth();
        StaminaFalling();
        StaminaRegen();

        HealthBar.Value = HealthPoints;
        StaminaBar.Value = Stamina;
        if (Input.GetKeyDown(KeyCode.M))
        {
            HealthPoints -= 10;
        }
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
    public void StaminaRegen()
    {
        if(!Sprint && Stamina < MaxStamina)
        {
            Stamina += Time.deltaTime * 2;
        }
    }
    public void addXP(int xpquantity)
    {
        XP = XP + xpquantity;
    }
}
