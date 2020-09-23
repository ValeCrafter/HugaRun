using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Rigidbody2D Rigidbody2D;

    float HorizontalMoveKeyboard = 0f;
    float HorizontalMoveButton = 0f;
    float VerticalMove = 0f;
    public float runSpeed = 40f;
    bool jump = true;
    bool grounded;
    bool jumped;
    bool fromjump;
    bool fromfall;
    float Horizontal;
    bool jumpbutton = false;

    public Animator animator;



    //Update is called once per frame
    void Update()
    {
        grounded = controller.Grounded;


        HorizontalMoveKeyboard = Input.GetAxisRaw("Horizontal") * runSpeed;

        HorizontalMoveButton= Horizontal * runSpeed;

        animator.SetFloat("Speed", Math.Abs(HorizontalMoveKeyboard));
        animator.SetFloat("Speed", Math.Abs(HorizontalMoveButton));


        if (Input.GetButtonDown("Jump") && !fromfall) 
        {
            jump = true;
            jumped = true;

        }

        if (jumpbutton && !fromfall)
        {
            jump = true;
            jumped = true;
        }



        if (!grounded && jumped) //jumping anim
        {
            animator.SetBool("Jumping", true);
            jumped = false;
            fromjump = true;

        }


        if (!grounded && !jumped && !fromjump) //falling anim
        {

            animator.SetBool("Falling", true);
            fromfall = true;
        }

        if (grounded)
        {
            fromjump = false;
            fromfall = false;
            animator.SetBool("Falling", false);
        }





    }

    public void OnLanding ()
    {
        animator.SetBool("Jumping", false);

    }

    private void FixedUpdate()
    {
        controller.Move(HorizontalMoveButton * Time.fixedDeltaTime, false, jump);
        jump = false;


    }

    public void Jump()
    {
        jumpbutton = true;
    }

    public void NotJump()
    {
        jumpbutton = false;
    }

    public void Right()
    {
        Horizontal = 1;
    }
    public void Left()
    {
        Horizontal = -1;
    }

    public void Stop()
    {
        Horizontal = 0;
    }
}
