using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    public GameObject impactanimation;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = transform.right * projectileSpeed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(impactanimation, transform.position, Quaternion.identity);
        Destroy(gameObject);

        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }





    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "SpikedProjectile(Clone)" || gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject, 8);
        }
    }
}
