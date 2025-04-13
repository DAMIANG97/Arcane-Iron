using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    public Player player; // Odwołanie do skryptu Player

    void Start()
    {
        if (player == null)
        {
            player = GetComponent<Player>();
        }
    }

    public int GetStat(string statName)
    {
        switch (statName.ToLower())
        {
            case "strength":
                return player.strength;
            case "dexterity":
                return player.dexterity;
            case "charisma":
                return player.charisma;
            case "intelligence":
                return player.intelligence;
            case "power":
                return player.power;
            case "hp":
                return player.hp;
            case "level":
                return player.lv;
            case "featurepoints":
                return player.featurePoints;
            default:
                Debug.LogWarning("Unknown stat: " + statName);
                return -1;
        }
    }

    public void SetStat(string statName, int value)
    {
        switch (statName.ToLower())
        {
            case "strength":
                player.strength = value;
                break;
            case "dexterity":
                player.dexterity = value;
                break;
            case "charisma":
                player.charisma = value;
                break;
            case "intelligence":
                player.intelligence = value;
                break;
            case "power":
                player.power = value;
                break;
            case "hp":
                player.hp = value;
                break;
            case "level":
                player.lv = value;
                break;
            case "featurepoints":
                player.featurePoints = value;
                break;
            default:
                Debug.LogWarning("Unknown stat: " + statName);
                break;
        }
    }
}
