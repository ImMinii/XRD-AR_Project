using UnityEngine;

public class HideObject : MonoBehaviour
{    
    public GameObject targetObject;
    
    public void ToggleObject()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}
