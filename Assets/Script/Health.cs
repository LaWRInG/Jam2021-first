using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
 
    [SerializeField] private float health = 10f;
    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Hit! current " + health);
        if (health < 0.01)
        {
            Destroy(gameObject);
        }
    }
    

}
