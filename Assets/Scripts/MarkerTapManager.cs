using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

public class MarkerTapManager : MonoBehaviour
{
    private Camera arCamera;
    [SerializeField] public ObjectSpawner ObjectSpawner;

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
                MarkerScript marker = hit.collider.GetComponentInChildren<MarkerScript>();
                if (marker != null)
                {
                    marker.ShowPopup();
                    return; // stop at the first marker hit
                }
                if (hit.collider.CompareTag("Board"))
                {
                    return; // Lock board if misclick
                }
            }
            foreach (RaycastHit hit in hits)
            {
                var hitPlane = hit.transform.gameObject.GetComponent<ARPlane>();
                if (hitPlane != null)
                {
                    ObjectSpawner.TrySpawnObject(hit.point, hitPlane.normal);
                }
            }
        }
    }
}
