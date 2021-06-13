using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CombatManager : MonoBehaviour
{
    public static CombatManager ins;

    [Header("Animator Player")]
    public Animator anim;
    [Header("Combat")]
    public bool attacking;
    public bool attackR;
    public bool attackL;
    [SerializeField] float attackRange = 0.5f;
    [SerializeField] LayerMask enemyLayers;
    [SerializeField] Transform attackPoint;

    private void Awake()
    {
        ins = this;
        anim = GetComponent<Animator>();
    }

    public void AttackR(InputAction.CallbackContext context)
    {
        Debug.Log("click");
        if (context.performed)
        {
            if(PlayerControls.ins.transform.localScale == new Vector3(-1f, 1, 1f))
            {
                PlayerControls.ins.transform.localScale = Vector3.one;
            }

            attacking = true;
            attackR = false;

            Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnimies)
            {
                Debug.Log("hit");
            }

            if (context.canceled)
            {
                attackR = false;
            }
        }
    }

    public void AttackL(InputAction.CallbackContext context)
    {
        Debug.Log("click");
        if (context.performed)
        {
            if (PlayerControls.ins.transform.localScale == Vector3.one)
            {
                PlayerControls.ins.transform.localScale = new Vector3(-1f, 1, 1f);
            }

            attacking = true;
            attackL = true;

            Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnimies)
            {
                Debug.Log("hit");
            }

            if (context.canceled)
            {
                attackL = false;
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
