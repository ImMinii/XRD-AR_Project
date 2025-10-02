using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem; // Required for new Input System

public class MarkerTapManager : MonoBehaviour
{
    private Camera arCamera;

    void Start()
    {
        arCamera = Camera.main;
    }

    void Update()
    {
        // Check for touch or click using new Input System
        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame)
        {
            Vector2 screenPos = Pointer.current.position.ReadValue();

            // Avoid clicking UI
            if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
                return;

            Ray ray = arCamera.ScreenPointToRay(screenPos);
            // Use RaycastAll to get all objects hit along the ray
            RaycastHit[] hits = Physics.RaycastAll(ray);

            foreach (RaycastHit hit in hits)
            {
                MarkerScript marker = hit.transform.GetComponent<MarkerScript>();
                if (marker != null)
                {
                    marker.ShowPopup();
                    break; // stop at the first marker hit
                }
            }
        }
    }
}
