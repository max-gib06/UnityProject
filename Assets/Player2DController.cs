using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DController : MonoBehaviour
{
    public Animator animator;
    public float PlayerMovementSpeed = 1;
    public float JumpHeight = 5;
    public float DoubleJump = 5;
    public int counter = 0;
    public bool timer = false;
    public bool facingRight = true;

    private Rigidbody2D _rigidbody;

    [SerializeField]
    private LayerMask groundLayer;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.freezeRotation = true;
    }


    void Update()
    {
        Move();
        Jump();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            Destroy(other.gameObject);
        }
    }



    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKeyDown(KeyCode.LeftShift) && Mathf.Abs(_rigidbody.velocity.y) < 0.0001f)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, DoubleJump);
            animator.SetBool("IsJumping", true);

            OnLanding();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rigidbody.velocity.y) < 0.0001f)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, JumpHeight);
            animator.SetBool("IsJumping", true);
            FindObjectOfType<SoundManager>().Play("Jump");
            OnLanding();
        }

    }

    public void OnLanding()
    {
        if (timer == true)
        {
            counter++;
        }
        if (counter >= 0.01f)
        {
            animator.SetBool("IsJumping", false);
        }
        //counter = 0;
    }

    void Move()
    {

        var movement = Input.GetAxis("Horizontal");
        Flip(movement);
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * PlayerMovementSpeed;
        animator.SetFloat("Speed", Math.Abs(movement));

        if (movement < 0.1f)
        {
            animator.SetBool("IsJumping", false);
        }
    

    }


    private void Flip(float movement)
    {
        if (movement > 0 && facingRight)

        {
            
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x = 1 * 5;

            transform.localScale = theScale;

            FindObjectOfType<SoundManager>().Play("Walk");



        }

        else if (movement < 0 && !facingRight)

        {
            
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x = -1 * 5;

            transform.localScale = theScale;

            FindObjectOfType<SoundManager>().Play("Walk");

        }
    }
}


