using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class Choice
{
    public string text;
    public string nextScene;
    public int successRoll;
    public int hpLose;
    public string success;
}

[System.Serializable]
public class SceneData
{
    public string Scene;
    public string text;
    public string image;
    public int Hp;
    public int DMG;
    public int successRoll;
    public string Success;
    public string Fail;

    public List<Choice> choices;
}

[System.Serializable]
public class SceneContainer
{
    public List<SceneData> Events = new List<SceneData>();
}

public class SceneLoader
{
    private static SceneContainer sceneContainer;

    public static void LoadSceneData()
    {
        string json = string.Empty;

#if UNITY_ANDROID || UNITY_IOS
        TextAsset[] jsonFiles = Resources.LoadAll<TextAsset>("Scenes");
        if (jsonFiles.Length == 0)
        {
            Debug.LogError("No JSON files found in Resources/Scenes folder");
            return;
        }
        TextAsset randomJsonFile = jsonFiles[Random.Range(0, jsonFiles.Length)];
        json = randomJsonFile.text;
#else
        string path = Application.streamingAssetsPath + "/yourfile.json";
        if (!File.Exists(path))
        {
            Debug.LogError("JSON file not found: " + path);
            return;
        }
        json = File.ReadAllText(path);
#endif

        sceneContainer = JsonUtility.FromJson<SceneContainer>(json);

        if (sceneContainer == null || sceneContainer.Events.Count == 0)
        {
            Debug.LogError("Invalid or empty scene data");
            sceneContainer = new SceneContainer();
        }
    }

    public static SceneData GetSceneData(int index)
    {
        if (sceneContainer != null && index >= 0 && index < sceneContainer.Events.Count)
        {
            return sceneContainer.Events[index];
        }
        Debug.LogError("Invalid index or data not loaded");
        return null;
    }
}
