using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{



    public int hp = 5;
    public int strength = 5;
    public int dexterity = 5;
    public int charisma = 5;
    public int intelligence = 5;
    public int power = 5;
    public int lv = 1;

    private int exp = 0;


    public int featurePoints = 10;

    void Start()
    {

    }

    public void AddStrength()
    {
        if (featurePoints > 0)
        {
            strength++;
            featurePoints--;
            Debug.Log("Increased Strength.");
        }
    }
    public void AddDexterity()
    {
        if (featurePoints > 0)
        {
            dexterity++;
            featurePoints--;
            Debug.Log("Increased Strength.");
        }
    }
    public void AddCharisma()
    {
        if (featurePoints > 0)
        {
            charisma++;
            featurePoints--;
            Debug.Log("Increased Strength.");
        }
    }
    public void AddIntelligence()
    {
        if (featurePoints > 0)
        {
            intelligence++;
            featurePoints--;
            Debug.Log("Increased Strength.");
        }
    }
    public void AddPower()
    {
        if (featurePoints > 0)
        {
            power++;
            featurePoints--;
            Debug.Log("Increased Strength.");
        }
    }
    public void Reset()
    {
        if (featurePoints > 0)
        {
            strength = 5;
            power = 5;
            intelligence = 5;
            dexterity = 5;

            featurePoints = 10;
            Debug.Log("Increased Strength.");
        }
    }
}
