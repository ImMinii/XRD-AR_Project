using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

public class AnimationPlacer : MonoBehaviour
{
    [SerializeField] public float OffsetAboveSurface = 0.1f;

    public void Start()
    {
    }

    public void Update()
    {
        var arCamera = Camera.main;

        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame)
        {
            Vector2 screenPos = Pointer.current.position.ReadValue();

            if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }

            Ray ray = arCamera.ScreenPointToRay(screenPos);
            RaycastHit[] hits = Physics.RaycastAll(ray);

            foreach (RaycastHit hit in hits)
            {
                var hitObject = hit.transform.gameObject;
                var hitPlane = hitObject.GetComponent<ARPlane>();
                if (hitPlane != null)
                {
                    var anim = FindFirstObjectByType<AnimationManager>();
                    var animObject = anim.gameObject;

                    var normal = hitPlane.normal;
                    var placePos = hit.point + normal * OffsetAboveSurface;
                    var towardsPos = arCamera.transform.position;
                    var forward = towardsPos - placePos;
                    BurstMathUtility.ProjectOnPlane(forward, normal, out var projectedForward);

                    animObject.transform.rotation = Quaternion.LookRotation(projectedForward, normal);
                    animObject.transform.position = placePos;
                    animObject.SetActive(true);
                    anim.Restart();
                }
            }
        }
    }
}
