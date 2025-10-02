using UnityEngine;

public enum BobberAxis
{
    X,
    Y,
    Z
}

public class Bobber : MonoBehaviour
{
    [SerializeField] public float Speed;
    [SerializeField] public float Magnitude;
    [SerializeField] public BobberAxis Axis;

    void Start()
    {

    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * Speed) * Magnitude;

        var pos = transform.localPosition;
        switch (Axis)
        {
            case BobberAxis.X:
                pos.x = offset;
                break;

            case BobberAxis.Y:
                pos.y = offset;
                break;

            case BobberAxis.Z:
                pos.z = offset;
                break;
        }
        transform.localPosition = pos;
    }
}
