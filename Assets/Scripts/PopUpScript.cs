using TMPro;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    public GameObject panel;       // The UI Panel for the popup
    public TextMeshProUGUI infoText;          // The Text element inside the panel

    public void ShowInfo(string message)
    {
        panel.SetActive(true);
        infoText.text = message;
    }

    public void HideInfo()
    {
        panel.SetActive(false);
    }
}
