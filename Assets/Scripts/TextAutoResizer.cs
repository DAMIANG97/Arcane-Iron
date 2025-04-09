using UnityEngine;
using TMPro;

public class TextAutoResizer : MonoBehaviour
{
    private TextMeshProUGUI textComponent;
    private RectTransform textRectTransform;

    void Awake()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
        textRectTransform = GetComponent<RectTransform>();

        if (textComponent == null)
        {
            Debug.LogError("Brak komponentu TextMeshProUGUI na obiekcie: " + gameObject.name);
        }
    }

    void Update()
    {
        UpdateHeight();
    }

    public void UpdateHeight()
    {
        if (textComponent != null && textRectTransform != null)
        {
            textRectTransform.sizeDelta = new Vector2(textRectTransform.sizeDelta.x, textComponent.preferredHeight);
        }
    }
}
