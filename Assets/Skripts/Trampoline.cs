﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
	private bool customSpeed = true;
	public Vector2 customVelocity;
	//private float multiplier;


	bool onTop;
	public GameObject bouncer;
	Animator anim;
	Vector2 velocity;

	// Use this for initialization
	void Start()
	{
		anim = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{

	}



	void OnCollisionStay2D(Collision2D other)
	{

		if (onTop)
		{
			anim.SetBool("isStepped", true);
			bouncer = other.gameObject;
		}


	}



	void OnTriggerEnter2D()
	{
		onTop = true;
	}
	void OnTriggerExit2D()
	{
		onTop = false;
		anim.SetBool("isStepped", false);

	}

	void OnTriggerStay2D()
	{
		onTop = true;
	}


	void Jump()
	{

		if (customSpeed)
			velocity = customVelocity;
		//else
			//velocity = transform.up * multiplier;



		bouncer.GetComponent<Rigidbody2D>().velocity = velocity;

	}
}

