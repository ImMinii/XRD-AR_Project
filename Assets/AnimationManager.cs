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

    public void Start()
    {
        Waypoints = WaypointsParent.GetComponentsInChildren<AnimationWaypoint>();
    }

    public void Update()
    {
        // Go to to next waypoint
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

        // Animate cursor towards current waypoint
        if (WaypointIndex < Waypoints.Length)
        {
            var targetPos = Waypoints[WaypointIndex].gameObject.transform.position;
            var oldPos = Cursor.transform.position;
            var newPos = Vector3.Lerp(oldPos, targetPos, Time.deltaTime * CursorSpeed);
            Cursor.transform.position = newPos;
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
            Waypoints[index].gameObject.SetActive(active);
            Text.text = Waypoints[index].Text;
        }
        else
        {
            if (active)
            {
                Text.text = "";
            }
        }
    }
}
