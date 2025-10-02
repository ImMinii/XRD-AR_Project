
 using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Profiling.FrameDataView;
public class MarkerScript : MonoBehaviour
{
  
    [TextArea]
    public string markerInfoText;  // Info to show when this marker is clicked

    private PopUpScript popup;

    void Start()
    {
        // Find the popup in the scene (make sure it has the "InfoPopup" script)
        popup = FindFirstObjectByType<PopUpScript>();
        if(popup != null)
        {
            ;
        }
    }

    public void ShowPopup()
    {
        if (popup != null)
        {
            popup.ShowInfo(markerInfoText);
        }
    }

}
