using UnityEngine;

public class ShowPlayerStats : MonoBehaviour
{
    public GameObject targetObject; // zmieniono nazwę, żeby uniknąć konfliktu z Unity

    public void ToggleVisibility()
    {
        if (targetObject != null)
        {
            bool isActive = targetObject.activeSelf;
            targetObject.SetActive(!isActive);
        }
    }
}
