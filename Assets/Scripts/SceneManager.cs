using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSaveManager : MonoBehaviour
{
    private const string SavedSceneKey = "SavedScene";


    private void Start()
    {
        if (PlayerPrefs.HasKey(SavedSceneKey))
        {
            string savedScene = PlayerPrefs.GetString(SavedSceneKey);
            if (savedScene != SceneManager.GetActiveScene().name)
            {
                SceneManager.LoadScene(savedScene);
            }
        }
    }

    // Zapisz bieżącą scenę
    public void SaveCurrentScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString(SavedSceneKey, currentScene);
        PlayerPrefs.Save();
        Debug.Log("Zapisano scenę: " + currentScene);
    }

    // Załaduj zapisaną scenę (jeśli istnieje)
    public void LoadSavedScene()
    {
        if (PlayerPrefs.HasKey(SavedSceneKey))
        {
            string savedScene = PlayerPrefs.GetString(SavedSceneKey);
            SceneManager.LoadScene(savedScene);
        }
        else
        {
            Debug.LogWarning("Brak zapisanej sceny.");
        }
    }

    // Wyczyszczenie zapisu
    public void ClearSavedScene()
    {
        PlayerPrefs.DeleteKey(SavedSceneKey);
        Debug.Log("Usunięto zapis sceny.");
    }
}
