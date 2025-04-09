using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneTextDisplay : MonoBehaviour
{
    public TextMeshProUGUI sceneText;
    public string variableName = "text";

    void Start()
    {

        SceneLoader.LoadSceneData();

        SceneData sceneData = SceneLoader.GetSceneData(0);

        if (sceneData != null)
        {
            sceneText.text = sceneData.text;
        }
        else
        {
            sceneText.text = "Failed to load scene data.";
        }
    }
}
