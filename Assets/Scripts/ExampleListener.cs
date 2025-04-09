using UnityEngine;
using System.Collections.Generic;

public class ExampleListener : MonoBehaviour
{
    public TypewriterEffect typewriterEffect;
    public List<GameObject> objectsToShow; // Lista obiektów do pokazania po zakończeniu pisania

    void Start()
    {
        if (typewriterEffect != null)
        {
            typewriterEffect.OnTypingComplete += HandleTypingComplete;
        }

        // Ukrywamy wszystkie obiekty na starcie
        if (objectsToShow != null)
        {
            foreach (GameObject obj in objectsToShow)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
        }
    }

    private void HandleTypingComplete()
    {
        Debug.Log("Tekst został w pełni wyświetlony!");

        // Pokazujemy wszystkie obiekty z listy
        if (objectsToShow != null)
        {
            foreach (GameObject obj in objectsToShow)
            {
                if (obj != null)
                {
                    obj.SetActive(true);
                }
            }
        }
    }

    private void OnDestroy()
    {
        if (typewriterEffect != null)
        {
            typewriterEffect.OnTypingComplete -= HandleTypingComplete;
        }
    }
}