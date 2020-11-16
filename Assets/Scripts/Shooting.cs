using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bala;
    public List<GameObject> poolBalas;
    public int poolBalasCount = 20;
    public Transform canon;

    private void Start()
    {
        for (int i = 0; i < poolBalasCount; i++)
        {
            GameObject poolBala = Instantiate(bala, new Vector3(0, 0, 0), Quaternion.identity);
            poolBala.SetActive(false);
            poolBalas.Add(poolBala);
        }
    }
    public void Shoot()
    {
        NotificacionManager.MostrarNotificacion("Has disparado", "Dejame volver al juego");
        GameObject balaDisparada = poolBalas[0];
        balaDisparada.SetActive(true);
        balaDisparada.transform.position = canon.position;
        poolBalas.Insert(poolBalas.Count, balaDisparada);
        poolBalas.RemoveAt(0);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
