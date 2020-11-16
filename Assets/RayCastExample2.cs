using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastExample2 : MonoBehaviour
{
    public float length = 10;
    public Material materialToChange;
    public Transform secondObject;

    // Update is called once per frame
    void Update()
    {
        Vector3 diferencia = secondObject.position - transform.position;
        RaycastHit hit;
        Debug.DrawRay(transform.position, diferencia.normalized * 2, Color.red);
        if (Physics.Raycast(transform.position, diferencia.normalized, out hit, 2))
        {
           
            Debug.Log(hit.transform.name);
            hit.transform.GetComponent<Renderer>().material = materialToChange;
        }    
        else
        {
            Debug.Log("no estoy tocando nada");
        }
    }
}
