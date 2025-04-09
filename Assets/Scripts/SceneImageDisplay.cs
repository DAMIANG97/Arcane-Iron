using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneImageDisplay : MonoBehaviour
{
    public Image sceneImage;

    void Start()
    {
        // Załaduj dane sceny, jeśli nie są jeszcze załadowane
        SceneLoader.LoadSceneData();

        // Pobierz pierwszą scenę
        SceneData sceneData = SceneLoader.GetSceneData(0);

        if (sceneData != null && !string.IsNullOrEmpty(sceneData.image))
        {
            StartCoroutine(LoadSceneImage(sceneData.image));
        }
    }

    IEnumerator LoadSceneImage(string imageName)
    {
        string imagePath = "Images/" + System.IO.Path.GetFileNameWithoutExtension(imageName);
        Sprite sprite = Resources.Load<Sprite>(imagePath);

        if (sprite != null)
        {
            sceneImage.sprite = sprite;
        }
        else
        {
            Debug.LogError("Image not found: " + imagePath);
        }
        yield return null;
    }
}
