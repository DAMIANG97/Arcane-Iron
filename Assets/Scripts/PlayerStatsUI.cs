using TMPro;
using UnityEngine;
using UnityEngine.UI;
// using TMPro; // jeśli używasz TMP

public class StatDisplayUI : MonoBehaviour
{
    public PlayerStatsManager statsManager; // Przypinasz go do skryptu w grze
    public string statName;                 // Np. wpisz "strength", "power", "dexterity"
    public TMP_Text statText;                // UI tekst, do którego będzie wpisywana wartość
    // public TMP_Text statText;            // Odkomentuj, jeśli używasz TextMeshPro

    void Update()
    {
        if (statsManager == null || string.IsNullOrEmpty(statName))
        {
            return;
        }

        int value = statsManager.GetStat(statName);
        statText.text = $"{value}";
    }
}
