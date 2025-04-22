using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartUIManager : MonoBehaviour
{
    public GameObject heartFullPrefab;
    public GameObject heartEmptyPrefab;
    public Transform heartsContainer;
    public Player player;

    private List<GameObject> hearts = new List<GameObject>();

    void Update()
    {
        UpdateHeartsUI();
    }

    public void UpdateHeartsUI()
    {
        // Usuń stare serduszka
        foreach (GameObject heart in hearts)
        {
            Destroy(heart);
        }
        hearts.Clear();

        // Dodaj pełne serca
        for (int i = 0; i < player.hp; i++)
        {
            GameObject heart;

            if (i < player.currentHp)
            {
                heart = Instantiate(heartFullPrefab, heartsContainer);
            }
            else
            {
                heart = Instantiate(heartEmptyPrefab, heartsContainer);
            }

            hearts.Add(heart);
        }
    }
}
