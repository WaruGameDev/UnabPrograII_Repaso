using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovimientoPorEnum : MonoBehaviour
{
    public MovimientoPorEnum movimiento;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            movimiento.direccion = MovimientoPorEnum.DIRECCION_MOVIMIENTO.ARRIBA;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            movimiento.direccion = MovimientoPorEnum.DIRECCION_MOVIMIENTO.ABAJO;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            movimiento.direccion = MovimientoPorEnum.DIRECCION_MOVIMIENTO.IZQUIERDA;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            movimiento.direccion = MovimientoPorEnum.DIRECCION_MOVIMIENTO.DERECHA;
        }
    }
}
