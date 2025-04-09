using UnityEngine;

public class PositionUiList : MonoBehaviour
{
    public RectTransform[] elements; // Lista elementów UI
    public float offset = 50f; // Odstęp między elementami

    void FixedUpdate()
    {
        PositionElements();
    }

    void PositionElements()
    {
        if (elements == null || elements.Length == 0)
            return;

        float currentY = 0f;

        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] == null)
                continue;

            // Jeśli to nie pierwszy element, to przesuwamy go o wysokość poprzedniego + offset
            if (i > 0)
                currentY -= elements[i - 1].rect.height + offset;

            // Ustawienie pozycji
            Vector2 newPosition = elements[i].anchoredPosition;
            newPosition.y = currentY;
            elements[i].anchoredPosition = newPosition;
        }
    }
}