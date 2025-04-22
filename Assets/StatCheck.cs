using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StatCheck : MonoBehaviour
{
    public Player player; // Referencja do skryptu gracza
    public StatType selectedStat; // Wybrana statystyka
    public int requiredValue = 15; // Próg sukcesu

    [Header("Sceny do załadowania")]
    public string successSceneName; // Nazwa sceny przy sukcesie
    public string failSceneName;    // Nazwa sceny przy porażce

    [Header("UI")]
    public TMP_Text tmpText; // TextMeshPro do wyświetlania szansy
    public string textPrefix = "Szansa na sukces: "; // Tekst przed wartością procentową

    public enum StatType
    {
        Strength,
        Dexterity,
        Intelligence,
        Charisma,
        Power
    }

    private void Update()
    {
        if (tmpText != null && player != null)
        {
            int statValue = GetStatValue();
            float successChance = CalculateSuccessChance(statValue, requiredValue);
            tmpText.text = $"{textPrefix} - {successChance:F1}%";
        }
    }

    public void RollCheck()
    {
        int statValue = GetStatValue();
        int diceRoll = Random.Range(1, 20); // d20 (1–20)
        int total = statValue + diceRoll;

        Debug.Log($"Rzut: d20 = {diceRoll}, {selectedStat} = {statValue}, Suma = {total}");

        if (total >= requiredValue)
        {
            Debug.Log("SUKCES!");
            if (!string.IsNullOrEmpty(successSceneName))
                SceneManager.LoadScene(successSceneName);
        }
        else
        {
            if (player != null)
                player.TakeDamage(1);
            Debug.Log("PORAŻKA.");
            if (!string.IsNullOrEmpty(failSceneName))
                SceneManager.LoadScene(failSceneName);
        }
    }

    private int GetStatValue()
    {
        switch (selectedStat)
        {
            case StatType.Strength: return player.strength;
            case StatType.Dexterity: return player.dexterity;
            case StatType.Intelligence: return player.intelligence;
            case StatType.Charisma: return player.charisma;
            case StatType.Power: return player.power;
            default: return 0;
        }
    }

    private float CalculateSuccessChance(int stat, int required)
    {
        int successCount = 0;
        for (int i = 1; i <= 20; i++)
        {
            if (i + stat >= required)
            {
                successCount++;
            }
        }
        return (successCount / 20f) * 100f;
    }
}
