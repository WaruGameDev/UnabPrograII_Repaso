using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
[System.Serializable]
public class Notificacion
{
    public string textoNotificacion;
    public string textoBoton;
}

public class NotificacionManager : MonoBehaviour
{
    public static NotificacionManager sNotificacionManager;
    public TextMeshProUGUI textoNotificacionUI, textoBotonUI;
    public float speedAnimation;
    public RectTransform panelNotificacion;

    private void Awake()
    {
        sNotificacionManager = this;
    }

    public static void MostrarNotificacion(string notificacionTexto, string botonTexto)
    {
        sNotificacionManager.textoBotonUI.text = botonTexto;
        sNotificacionManager.textoNotificacionUI.text = notificacionTexto;
        sNotificacionManager.panelNotificacion.DOScale(1, sNotificacionManager.speedAnimation).SetEase(Ease.OutCubic);
        sNotificacionManager.panelNotificacion.DOShakeRotation(sNotificacionManager.speedAnimation, new Vector3(0,0,500), 10);

    }
    public static void EsconderNotificacion()
    {
        sNotificacionManager.panelNotificacion.DOScale(0, sNotificacionManager.speedAnimation).SetEase(Ease.OutCubic);
    }

    //debug
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            NotificacionManager.MostrarNotificacion("Holi, soy una notificacion de prueba", "Ah, ya veo");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            NotificacionManager.EsconderNotificacion();
        }
    }
}
