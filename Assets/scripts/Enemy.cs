using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    public int health = 100;

    public int value = 50;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        Debug.Log("BUZ " + Waypoints.points[1]);
        target = Waypoints.points[0];

    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        PlayerStats.Money += value;
        Destroy(gameObject);
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
            EndPath();
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }

    void Otaceni(Vector3 d, Vector3 f)
    {
        //transform.forward = d;
        transform.forward = Vector3.RotateTowards(f.normalized, d.normalized, 0.1f, 0);
    }
}
