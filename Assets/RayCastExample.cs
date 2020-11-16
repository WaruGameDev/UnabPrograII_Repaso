using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastExample : MonoBehaviour
{
    public Material materialACambiar;
    public float lenght = 10;

    private void Update()
    {
        RaycastHit hit;
        //dibujar rayo de referencia
        Debug.DrawRay(transform.position, transform.forward * lenght, Color.red);
        //raycast
        if(Physics.Raycast(transform.position, transform.forward, out hit, lenght))
        {
            hit.transform.GetComponent<Renderer>().material = materialACambiar;
            hit.transform.Translate((hit.transform.position - transform.position) * -3 * Time.deltaTime);
        }
    }


}
