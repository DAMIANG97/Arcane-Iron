using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public float speed = 0.01f;
    public AudioSource audioSource;
    public AudioClip typeSound;
    public float pauseAfterDot = 0.5f;

    private string fullText = "";
    private Coroutine typingCoroutine;
    private bool isTyping = false;
    private int silentCount = 0;
    private bool hasStarted = false;

    public event Action OnTypingComplete;

    void Start()
    {
        if (textComponent != null)
        {
            fullText = textComponent.text;
            textComponent.text = "";
            StartTyping();
        }
    }

    void Update()
    {
        if (isTyping && Input.GetMouseButtonDown(0))
        {
            SkipTyping();
        }
    }

    public void StartTyping()
    {
        if (hasStarted) return;
        hasStarted = true;

        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }

        typingCoroutine = StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        isTyping = true;
        textComponent.text = "";
        silentCount = 0;

        for (int i = 0; i < fullText.Length; i++)
        {
            textComponent.text += fullText[i];
            bool playedSound = false;

            if (typeSound != null && audioSource != null && fullText[i] != '.' && i % 6 == 0)
            {
                audioSource.PlayOneShot(typeSound, 0.5f);
                playedSound = true;
            }

            if (fullText[i] == '.')
            {
                if (typeSound != null && audioSource != null && silentCount >= 3)
                {
                    audioSource.PlayOneShot(typeSound, 0.5f);
                }
                silentCount = 0;
                yield return new WaitForSeconds(pauseAfterDot);
            }

            if (!playedSound)
            {
                silentCount++;
            }
            else
            {
                silentCount = 0;
            }

            yield return new WaitForSeconds(speed);
        }

        isTyping = false;
        OnTypingComplete?.Invoke();
    }

    private void SkipTyping()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }
        textComponent.text = fullText;
        isTyping = false;
        OnTypingComplete?.Invoke();
    }
}