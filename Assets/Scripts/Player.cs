using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int minStrength = 5;
    public int minPower = 5;
    public int minIntelligence = 5;
    public int minDexterity = 5;
    public int minCharisma = 5;
    public int currentHp = 5;
    public int hp = 5;
    public int strength = 5;
    public int dexterity = 5;
    public int charisma = 5;
    public int intelligence = 5;
    public int power = 5;
    public int lv = 1;

    private int exp = 0;

    public int minFeaturePoints = 10;
    public int featurePoints = 10;



    void Start()
    {
        strength = PlayerPrefs.GetInt("Strength", strength);
        dexterity = PlayerPrefs.GetInt("Dexterity", dexterity);
        charisma = PlayerPrefs.GetInt("Charisma", charisma);
        intelligence = PlayerPrefs.GetInt("Intelligence", intelligence);
        power = PlayerPrefs.GetInt("Power", power);
        currentHp = PlayerPrefs.GetInt("CurrentHP", currentHp);
        lv = PlayerPrefs.GetInt("Level", lv);
        featurePoints = PlayerPrefs.GetInt("FeaturePoints", featurePoints);
        exp = PlayerPrefs.GetInt("EXP", exp);

        minStrength = PlayerPrefs.GetInt("MinStrength", minStrength);
        minDexterity = PlayerPrefs.GetInt("MinDexterity", minDexterity);
        minCharisma = PlayerPrefs.GetInt("MinCharisma", minCharisma);
        minIntelligence = PlayerPrefs.GetInt("MinIntelligence", minIntelligence);
        minPower = PlayerPrefs.GetInt("MinPower", minPower);
        hp = PlayerPrefs.GetInt("HP", hp);
        minFeaturePoints = PlayerPrefs.GetInt("MinFeaturePoints", minFeaturePoints);
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

        featurePoints = minFeaturePoints;
        strength = minStrength;
        power = minPower;
        intelligence = minIntelligence;
        dexterity = minDexterity;
        charisma = minCharisma;
    }
    public void Accept()
    {
        minFeaturePoints = featurePoints;
        minStrength = strength;
        minPower = power;
        minIntelligence = intelligence;
        minDexterity = dexterity;
        minCharisma = charisma;

        PlayerPrefs.SetInt("Strength", strength);
        PlayerPrefs.SetInt("Dexterity", dexterity);
        PlayerPrefs.SetInt("Charisma", charisma);
        PlayerPrefs.SetInt("Intelligence", intelligence);
        PlayerPrefs.SetInt("Power", power);
        PlayerPrefs.SetInt("CurrentHP", currentHp);
        PlayerPrefs.SetInt("Level", lv);
        PlayerPrefs.SetInt("FeaturePoints", featurePoints);
        PlayerPrefs.SetInt("EXP", exp);

        PlayerPrefs.SetInt("MinStrength", minStrength);
        PlayerPrefs.SetInt("MinDexterity", minDexterity);
        PlayerPrefs.SetInt("MinCharisma", minCharisma);
        PlayerPrefs.SetInt("MinIntelligence", minIntelligence);
        PlayerPrefs.SetInt("MinPower", minPower);
        PlayerPrefs.SetInt("HP", hp);
        PlayerPrefs.SetInt("Level", lv);
        PlayerPrefs.SetInt("MinFeaturePoints", minFeaturePoints);
    }
}