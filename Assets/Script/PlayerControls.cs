using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    
    public static PlayerControls ins;

    private PlayerInputAction playerAction;

    [Header("Set-up")]
    public Animator anim;

    private Rigidbody2D rb;

    private Collider2D col;




    [Header("Movement")]
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpfroce = 5f;
    [SerializeField] private LayerMask ground;

    private float inputx;


    [Header("Combat")]
    public bool attacking;
    [SerializeField] float attackRange = 0.5f;
    [SerializeField] LayerMask enemyLayers;
    [SerializeField] Transform attackPoint;

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
        Debug.Log("click");
        float isAttack = context.ReadValue<float>();
        if (context.performed)
        {
            attacking = true;

            Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnimies)
            {
                Debug.Log("hit");
            }
        }
    }

 

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

