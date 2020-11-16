using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 10;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <=0)
        {
            Destroy(gameObject);
        }
    }
}
