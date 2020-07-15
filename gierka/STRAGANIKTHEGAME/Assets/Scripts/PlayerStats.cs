using Packages.Rider.Editor.Util;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float HealthPoints, Hunger, Stamina, Thirst, Money;
    public float MaxHealthPoints, MaxHunger, MaxStamina, MaxThirst;
    public int Strength, Condition, Charisma, Drivingskill, Hoochskill;
    public Slider xp_slider;
    public Text xp;
    public GameObject Skill_ui;
    public GameObject avaible_lvl;// this text in skill_ui
    public Text Strength_txt;
    public Text Condition_txt;
    public Text Charisma_txt;
    public Text Drivingskill_txt;
    public Text Hoochskill_txt;
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

        /* HealthBar.Value = HealthPoints;
         StaminaBar.Value = Stamina;*/
        if (Input.GetKeyDown(KeyCode.M))
        {
            HealthPoints -= 10;
        }
        if (Input.GetKeyDown(KeyCode.U))
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
        LvlUp();
    }

    private void HungerGrowth()
    {
        if (Hunger > 0)
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
        if (!Sprint && Stamina < MaxStamina)
        {
            Stamina += Time.deltaTime * 2;
        }
    }
    public void addXP(int xpquantity)
    {
        XP = XP + xpquantity;
    }
    public void onClickStrength()
    {
        SkillUpgrade(ref Strength, ref Strength_txt);
    }
    public void onClickCondition()
    {
        SkillUpgrade(ref Condition, ref Condition_txt);
    }
    public void onClickCharisma()
    {
        SkillUpgrade(ref Charisma, ref Charisma_txt);
    }
    public void onClickDrivingskill()
    {
        SkillUpgrade(ref Drivingskill, ref Drivingskill_txt);
    }
    public void onClickHoochskill()
    {
        SkillUpgrade(ref Hoochskill, ref Hoochskill_txt);
    }
    private void UpdateTextofLevelPoint()
    {
        Text lvl = avaible_lvl.GetComponent<Text>();
        lvl.text = "Avaible " + Point_to_add + " points...";
    }

    private void SkillUpgrade(ref int skill, ref Text skill_text)
    {
        if (avaible_lvl.active == true)
        {
            skill += 1;
            skill_text.text = skill.ToString();
            Point_to_add -= 1;
            if (Point_to_add == 0)
            {
                avaible_lvl.SetActive(false);
            }
            UpdateTextofLevelPoint();
        }
    }

    private void LvlUp()
    {
        xp_slider.value = XP;
        xp.text = XP.ToString() + "/1000";
        if (XP >= 1000)//this can be changed 
        {
            Lvl += 1;
            XP = 0;
            Point_to_add += 1;
            avaible_lvl.SetActive(true);
            UpdateTextofLevelPoint();
        }
    }

}