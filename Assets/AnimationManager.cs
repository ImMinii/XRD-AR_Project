using TMPro;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] public GameObject Cursor;
    [SerializeField] public float CursorSpeed;
    [SerializeField] public GameObject WaypointsParent;
    [SerializeField] public TextMeshProUGUI Text;

    private AnimationWaypoint[] Waypoints;
    private int WaypointIndex;
    private float WaypointElapsed;
    private Vector3 CursorTarget;

    public void Start()
    {
        Waypoints = WaypointsParent.GetComponentsInChildren<AnimationWaypoint>();
        Restart();
    }

    public void Update()
    {
        if (WaypointIndex < Waypoints.Length)
        {
            WaypointElapsed += Time.deltaTime;
            if (WaypointElapsed > Waypoints[WaypointIndex].Duration)
            {
                SetWaypointActive(WaypointIndex, false);
                WaypointIndex += 1;
                WaypointElapsed = 0.0f;
                SetWaypointActive(WaypointIndex, true);
            }
        }

        if (WaypointIndex < Waypoints.Length)
        {
            Cursor.transform.position = Vector3.Lerp(Cursor.transform.position, CursorTarget, Time.deltaTime * CursorSpeed);
        }
        else
        {
            Cursor.SetActive(false);
        }
    }

    public void Restart()
    {
        for (var i = 0; i < Waypoints.Length; i += 1)
        {
            SetWaypointActive(i, false);
        }

        SetWaypointActive(0, true);
        WaypointIndex = 0;
        WaypointElapsed = 0.0f;
    }

    public void SetWaypointActive(int index, bool active)
    {
        if (index < Waypoints.Length)
        {
            Debug.Log($"Waypoint {index}, active {active}");
            Waypoints[index].gameObject.SetActive(active);
            CursorTarget = Waypoints[index].gameObject.transform.position;
            Text.text = Waypoints[index].Text;
        }
    }
}
