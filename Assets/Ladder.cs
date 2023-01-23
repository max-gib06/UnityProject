using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour

{
    private float vertical;
    private float speed = 5f;
    private float gravity = 4f;
    private bool ladderToggle;
    private bool climbingToggle;
    [SerializeField] public Rigidbody2D _rigid;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if(ladderToggle && Mathf.Abs(vertical)> 0f)
        {
            climbingToggle = true;
        }
    }

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (climbingToggle)
        {
            _rigid.gravityScale = 0f;
            _rigid.velocity = new Vector2(_rigid.velocity.x, vertical * speed);
        }
        else
        {
            _rigid.gravityScale = gravity;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            ladderToggle = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            ladderToggle = false;
            climbingToggle = false;
        }
    }

}

