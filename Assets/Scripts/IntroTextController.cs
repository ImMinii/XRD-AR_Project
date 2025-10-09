using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class IntroTextController : MonoBehaviour
{
    [SerializeField] ObjectSpawner objectSpawner;
    [SerializeField] GameObject introText;

    void Awake()
    {
        if (objectSpawner != null)
            objectSpawner.objectSpawned += OnObjectSpawned;

        // Ensure text starts hidden
        if (introText != null)
            introText.SetActive(false);
    }

    void OnDestroy()
    {
        if (objectSpawner != null)
            objectSpawner.objectSpawned -= OnObjectSpawned;
    }

    void OnObjectSpawned(GameObject spawned)
    {
        if (introText != null)
            introText.SetActive(true);
    }
}