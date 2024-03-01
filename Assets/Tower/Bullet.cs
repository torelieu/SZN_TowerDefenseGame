using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform enemy;

    public float speed = 100f;

    public int damage = 50;

    public GameObject impactEffect;

    public void Seek(Transform _enemy)
    {
        enemy = _enemy;
    }

    void Update()
    {
        if (enemy == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir  = enemy.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame) 
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();

        if(e != null)
        {
            e.TakeDamage(damage);
            
        }

        
    }
    void HitTarget()
    {
        GameObject insEffect =  (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);


        Destroy(insEffect, 2f);
        Destroy(enemy.gameObject);
        Destroy(gameObject);
    }
}
