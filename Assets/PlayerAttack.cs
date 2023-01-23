using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    public Transform firingPoint;
   
    public float angle;

    [SerializeField]
    public GameObject projectile;

    private Vector2 rangePosition;

    // Update is called once per frame

    void Update()
    {
        rangePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        angle = Mathf.Atan2(rangePosition.y, rangePosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle - 0f);
        if (Input.GetMouseButtonDown(0))
        {
            FireProjectile();
        }
    }
    private void FireProjectile()
    {
        GameObject firedProjectile = Instantiate(projectile, firingPoint.position, firingPoint.rotation);
        firedProjectile.GetComponent<Rigidbody2D>().velocity = firingPoint.up * 10f;
    }
}
