using UnityEngine;
using TMPro;

public class AdjustTMPHeight : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public RectTransform rectTransform;

    void Start()
    {
        AdjustHeight();
    }

    void Update()
    {
        AdjustHeight();
    }

    void AdjustHeight()
    {
        if (textMeshPro == null || rectTransform == null) return;

        textMeshPro.ForceMeshUpdate();
        float textHeight = textMeshPro.preferredHeight;
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, textHeight);
    }
}
