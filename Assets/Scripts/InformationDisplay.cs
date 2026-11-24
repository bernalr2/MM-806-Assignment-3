using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InformationDisplay : MonoBehaviour
{
    [SerializeField] private GameObject objectName;

    [SerializeField] private GameObject objectDescription;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ToggleObjectNameText(false);
        ToggleObjectDescriptionText(false);
    }

    public void ToggleObjectNameText(bool bIsObjectNameActive)
    {
        objectName.SetActive(bIsObjectNameActive);
    }

    public void ToggleObjectDescriptionText(bool bIsObjectDescriptionActive)
    {
        objectDescription.SetActive(bIsObjectDescriptionActive);
    }

    public void ChangeObjectNameText(string newObjectNameText)
    {
        objectName.GetComponentInChildren<TextMeshProUGUI>().text = newObjectNameText;
    }

    public void ChangeObjectDescriptionText(string newObjectDescriptionText)
    {
        objectDescription.GetComponentInChildren<TextMeshProUGUI>().text = newObjectDescriptionText;
    }
}
