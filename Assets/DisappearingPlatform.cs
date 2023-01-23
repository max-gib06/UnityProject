using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    //public float timetogglePlatform = 2;
    public float time;
    //public bool enabled = true;
    private Rigidbody2D _rigid;

    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            StartCoroutine(Collapse());
        }

        IEnumerator Collapse()
        {
            yield return new WaitForSeconds(time);
            _rigid.isKinematic = false;
            GetComponent<Collider2D>().isTrigger = true;
            yield return 0;
        }
    }
   
}
