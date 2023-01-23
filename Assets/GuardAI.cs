using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardAI : MonoBehaviour
{

	public float speed;

	public bool MoveRight;


    void Update()
	{
		// Use this for initialization

		if (MoveRight)
		{

			transform.Translate(2 * Time.deltaTime * speed, 0, 0);

			//transform.localScale = new Vector2(4, 4);

		}

		else
		{

			transform.Translate(-2 * Time.deltaTime * speed, 0, 0);

			//transform.localScale = new Vector2(-4, 4);

		}

	}

    void OnTriggerEnter2D(Collider2D trig)
	
	{
		if (trig.gameObject.CompareTag("turn"))
		{
			if (MoveRight)
			{
				MoveRight = false;
			}
			else
			{
 			 MoveRight = true;

			}
		}
	}
}
