using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPorEnum : MonoBehaviour
{
    public enum DIRECCION_MOVIMIENTO
    {
        ARRIBA,
        ABAJO,
        IZQUIERDA,
        DERECHA
    }
    public DIRECCION_MOVIMIENTO direccion;
    public float speed = 3;

    private void Update()
    {
        switch (direccion)
        {
            case DIRECCION_MOVIMIENTO.ARRIBA:
                Mover(Vector3.up);
                break;
            case DIRECCION_MOVIMIENTO.ABAJO:
                Mover(Vector3.down);
                break;
            case DIRECCION_MOVIMIENTO.IZQUIERDA:
                Mover(Vector3.left);
                break;
            case DIRECCION_MOVIMIENTO.DERECHA:
                Mover(Vector3.right);
                break;
        }
    }
    public void Mover(Vector3 direccion)
    {
        transform.Translate(direccion * speed * Time.deltaTime);
    }


}
