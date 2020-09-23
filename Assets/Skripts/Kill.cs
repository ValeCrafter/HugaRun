using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class Kill : MonoBehaviour
{

    public new Rigidbody2D rigidbody;
    public float DeathVelocity;
    float yVelocity;

    private void FixedUpdate()
    {
        yVelocity = rigidbody.velocity.y;

        if (Math.Abs(yVelocity) >= DeathVelocity)
        {
            transform.position = new Vector3(-5, -1);
        }
    }
}