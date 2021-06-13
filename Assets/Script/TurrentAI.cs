using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentAI : MonoBehaviour
{
    [SerializeField] private float scanRadius = 3f;
    [SerializeField] private LayerMask layers;
    private Collider2D target;
    [SerializeField] private GameObject fireball;
    [SerializeField] private Transform firepoint;
    [SerializeField] private float fireDelay = 1f;
    public float speed;
    private Transform player;

    
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("Fire", 0f, fireDelay);
    }

    // Update is called once per frame
    private void Update()
    {
        CheckEnviroment();
        LookAtTarget();
    }
    private void CheckEnviroment()
    {
        target = Physics2D.OverlapCircle(transform.position, scanRadius, layers);
        if (target != null)
        {
            Debug.Log(target.gameObject.name);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, scanRadius);
    }
    private void LookAtTarget()
    {
        if (target != null)
        {
            Vector2 direction = target.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg- 90f;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
    private void Fire()
    {
        if (target != null)
        {
            Instantiate(fireball, firepoint.position, firepoint.rotation);
        }
    }
}
