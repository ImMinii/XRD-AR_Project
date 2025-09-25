using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class RunesScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var runesFirkantObject = GameObject.Find("RunesFirkant");
        var runesSliderObject = GameObject.Find("RunesSlider");

        var runesSlider = runesSliderObject.GetComponent<Slider>();
        Debug.Log(runesSlider);
        Debug.Log(runesSlider.value);

        var oldPos = runesFirkantObject.transform.position;
        var newPos = new Vector3(oldPos.x, runesSlider.value, oldPos.z);
        runesFirkantObject.transform.position = newPos;
    }
}
