using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public float lenght = 100;
    public float damage = 5;
    public float fuerza = 500;
    public Transform puntoOrigen;

    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(puntoOrigen.position, puntoOrigen.forward, out hit, lenght))
        {
            Health2 health = hit.transform.GetComponent<Health2>();
            if(health != null)
            {
                health.TakeDamage(damage);
                hit.rigidbody.AddForce((hit.transform.position - puntoOrigen.position).normalized * fuerza);
            }
        }
    }
    private void Update()
    {
        Debug.DrawRay(puntoOrigen.position, puntoOrigen.forward * lenght, Color.green);
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

}
