using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ShowUI : MonoBehaviour
{
    [SerializeField] private GameObject[] SetActiveOnEnable;

    [SerializeField] private ARPlaneManager planeManager;


    private void OnEnable()
    {
        SetActive(SetActiveOnEnable, true);
        if (!planeManager) return;

        planeManager.enabled = false;

        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }
    }

    private void SetActive(GameObject[] list, bool state)
    {
        if (list == null) return;
        foreach (var go in list)
        {
            if (go == null || go == gameObject) continue;
            go.SetActive(state);
        }
    }
}
