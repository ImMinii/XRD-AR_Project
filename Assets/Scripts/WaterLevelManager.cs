using UnityEngine;
using UnityEngine.UI;

public class WaterLevelController : MonoBehaviour
{
    [Header("References")]
    public Slider waterSlider;
    public Transform waterPlane;

    [Header("Height Settings")]
    public float minHeight = -1.5f;
    public float maxHeight = -0.5f;

    private void Start()
    {
        if (waterSlider != null)
        {
            waterSlider.onValueChanged.AddListener(OnSliderValueChanged);
        }

        // Initialize
        OnSliderValueChanged(waterSlider.value);
    }

    private void OnSliderValueChanged(float value)
    {
        if (waterPlane != null)
        {
            // Lerp between minHeight and maxHeight
            float newY = Mathf.Lerp(minHeight, maxHeight, value);
            Vector3 localPos = waterPlane.localPosition;  //
            localPos.y = newY;
            waterPlane.localPosition = localPos;
        }
    }
}
