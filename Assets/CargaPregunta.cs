using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargaPregunta : MonoBehaviour
{
    public Pregunta pregunta;
    public Text preguntaUI;
    public List<Text> respuestasUI;
    public int cantidadDeRespuestas = 4;
    public List<string> pool;
    public List<string> ordenPreguntas;

    public void ShowQuestion()
    {
        //cargamos la pregunta
        preguntaUI.text = pregunta.preguntaTexto;
        //limpiamos listas
        pool.Clear();
        ordenPreguntas.Clear();
        //desorden de respuestas
        pool.AddRange(pregunta.respuestasIncorrectas);
        ordenPreguntas.Add(pregunta.respuestaCorrecta);
        for (int i = 0; i < cantidadDeRespuestas -1; i++)
        {
            int a = Random.Range(0, pool.Count);
            ordenPreguntas.Add(pool[a]);
            pool.RemoveAt(a);
        }
        // cargar preguntas a la ui desordenadas
        bool respuestaAsignada = false;
        for (int i = 0; i < cantidadDeRespuestas; i++)
        {            
            int a = Random.Range(0, ordenPreguntas.Count);
            respuestasUI[i].text = ordenPreguntas[a];
            respuestasUI[i].GetComponentInParent<Respuesta>().esCorrecta = false;
            if(a == 0 && !respuestaAsignada)
            {
                respuestasUI[i].GetComponentInParent<Respuesta>().esCorrecta = true;
                respuestaAsignada = true;
            }
            ordenPreguntas.RemoveAt(a);
        }
    }    
}
