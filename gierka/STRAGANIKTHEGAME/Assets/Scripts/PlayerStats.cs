using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float HealthPoints, Hunger, Stamina, Thirst, Money;
    public float MaxHealthPoints, MaxHunger, MaxStamina, MaxThirst;
    public int Strength, Condition, Charisma, Drivingskill, Hoochskill;
    public GameObject Skill_ui;
    public GameObject avaible_lvl;// this text in skill_ui
    public static bool active_ui;
    public static int Point_to_add;
    public int Lvl;
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
        Strength = 0;
        Condition = 0;
        Charisma = 0;
        Drivingskill = 0;
        Hoochskill = 0;
        Point_to_add = 0;
        Lvl = 0;
        active_ui = false;
        Skill_ui.SetActive(active_ui);
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
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (active_ui == true)
            {
                active_ui = false;
                Skill_ui.SetActive(active_ui);
            }
            else
            {
                active_ui = true;
                Skill_ui.SetActive(active_ui);
            }
        }
        if (XP >= 1000)//this can be changed 
        {
            Lvl += 1;
            XP = 0;
            Point_to_add += 1;
            avaible_lvl.SetActive(true);
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
