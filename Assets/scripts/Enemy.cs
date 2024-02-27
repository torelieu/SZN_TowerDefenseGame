using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;


    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        Debug.Log("BUZ " + Waypoints.points[1]);
        target = Waypoints.points[0];

    }

    void Update()
    {
        Debug.Log(target);
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        Otaceni(dir, transform.forward);
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();

        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void Otaceni(Vector3 d, Vector3 f)
    {
        //transform.forward = d;
        transform.forward = Vector3.RotateTowards(f.normalized, d.normalized, 0.1f, 0);
    }
}
