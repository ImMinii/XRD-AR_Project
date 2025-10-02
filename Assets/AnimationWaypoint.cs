using UnityEngine;

public class AnimationWaypoint : MonoBehaviour
{
    [SerializeField] [TextArea(3, 10)] public string Text = "Hello, world";
    [SerializeField] public float Duration = 10.0f;
    [SerializeField] public Color GizmoColor = Color.yellow;
    [SerializeField] public float GizmoScale = 0.5f;

    public void OnDrawGizmos()
    {
        Gizmos.color = GizmoColor;
        Gizmos.DrawWireSphere(transform.position, GizmoScale);
    }
}
