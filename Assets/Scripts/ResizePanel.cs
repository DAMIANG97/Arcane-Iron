using UnityEngine;
using UnityEngine.UI;

public class ResizePanel : MonoBehaviour
{
    public RectTransform panel; // Panel, którego wysokość chcemy ustawić
    public RectTransform[] children; // Wszystkie obiekty wewnątrz

    void Update()
    {
        float totalHeight = 0;

        foreach (RectTransform child in children)
        {
            totalHeight += child.rect.height + 50f;
        }

        panel.sizeDelta = new Vector2(panel.sizeDelta.x, totalHeight);
    }
}
