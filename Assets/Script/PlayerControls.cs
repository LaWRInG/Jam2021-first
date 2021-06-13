using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float speed = 5f, jumpfroce = 5f;

    public static PlayerControls ins;

    private PlayerInputAction playerAction;

    private float inputx;

    public bool attacking;

    private Rigidbody2D rb;

    private Collider2D col;

    public Animator anim;

    [SerializeField] private LayerMask ground;



    private void Awake()
    {
        ins = this;
        col = this.GetComponent<Collider2D>();
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
        playerAction = new PlayerInputAction();
        //rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        anim.SetFloat("move", Mathf.Abs(inputx));

        if(inputx >= 1f)
        {
            transform.localScale = Vector3.one;
        }
        else if (inputx <= -1f)
        {
            transform.localScale = new Vector3(-1f, 1, 1f);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(inputx * speed, rb.velocity.y);
        anim.SetBool("isJump", !IsGrounded());
        anim.SetFloat("Yvelocity", rb.velocity.y);
    }


    private bool IsGrounded()
    {
        Vector2 topLeftPoint = transform.position;
        topLeftPoint.x -= col.bounds.extents.x;
        topLeftPoint.y += col.bounds.extents.y;

        Vector2 bottonRightPoint = transform.position;
        bottonRightPoint.x += col.bounds.extents.x;
        bottonRightPoint.y -= col.bounds.extents.y;


        return Physics2D.OverlapArea(topLeftPoint, bottonRightPoint, ground);
    }

    public void Jump(InputAction.CallbackContext obj)
    {
        if (IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpfroce), ForceMode2D.Impulse);
        }
    }

    public void Movement(InputAction.CallbackContext context)
    {
        inputx = context.ReadValue<Vector2>().x;
        Debug.Log(inputx);
        Debug.Log("WASD");
    }

    public void AttackR(InputAction.CallbackContext context)
    {
        float isAttack = context.ReadValue<float>();
        if (isAttack == 1)
        {
            attacking = true;
        }
    }
}

