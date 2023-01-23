using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    private Transform player;
    public float lineOfSight;
    public float fireRange;
    public GameObject projectile;
    public GameObject projectilePoint;
    private float fireRate = 0.5f;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < lineOfSight && distanceFromPlayer > fireRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        else if(distanceFromPlayer <= fireRange && fireRate <Time.time)
        {
            Instantiate(projectile, projectilePoint.transform.position, Quaternion.identity);
            fireRate = Time.time + fireRate;
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSight);
        Gizmos.DrawWireSphere(transform.position, fireRange);
    }
}
