using UnityEngine;
using System.Collections;

public class DisplayAfterText : MonoBehaviour
{
    public GameObject objectToActivate1; // Pierwszy obiekt do aktywacji
    public GameObject objectToActivate2; // Drugi obiekt do aktywacji
    public TypewriterEffect typewriterEffect; // Referencja do skryptu TypewriterEffect

    void Start()
    {
        if (typewriterEffect != null)
        {
            typewriterEffect.OnTypingComplete += ActivateObjects;
        }
    }

    void ActivateObjects()
    {
        Debug.Log("ActivateObjects zostało wywołane");
        if (objectToActivate1 != null) objectToActivate1.SetActive(true);
        if (objectToActivate2 != null) objectToActivate2.SetActive(true);
    }
}
