using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform origenDisparo;
    public float length = 100;
    public float damage = 5;
    public float strenghtForce = 2000f;


    private void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(origenDisparo.position, origenDisparo.forward * length, Color.green);
        if(Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(origenDisparo.position, origenDisparo.forward, out hit, length))
            {
                Health health = hit.transform.GetComponent<Health>();
                if(health != null)
                {
                    health.TakeDamage(damage);
                    hit.rigidbody.AddForce((hit.transform.position - transform.position).normalized * strenghtForce);
                }
            }
        }

        
    }

}
