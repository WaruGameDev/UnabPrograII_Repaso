using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionLoader : MonoBehaviour
{
    public Question question;
    public Text textoPreguntaUI;
    public int responseCount = 4;
    public List<Text> textoRespuestasUI;
    public List<string> ordenPreguntas;
    public List<string> pool;

    public void ShowQuestion()
    {
        // cambia texto pregunta
        textoPreguntaUI.text = question.textoPregunta;
        //limpia lista
        pool.Clear();
        ordenPreguntas.Clear();
        //question carga.
        pool.AddRange(question.otrasRespuestas);
        ordenPreguntas.Add(question.respuestaCorrecta);        

        for (int i = 0; i < responseCount -1; i++)
        {
            int a = Random.Range(0, pool.Count);
            ordenPreguntas.Add(pool[a]);
            pool.RemoveAt(a);            
        }
        
        for (int i = 0; i < responseCount; i++)
        {
            int a = Random.Range(0, ordenPreguntas.Count);
            textoRespuestasUI[i].text = ordenPreguntas[a];
            textoRespuestasUI[i].GetComponentInParent<Response>().IsCorrect = false;
            if (a == 0)
            {
                textoRespuestasUI[i].GetComponentInParent<Response>().IsCorrect = true;
            }
            ordenPreguntas.RemoveAt(a);
        }

    }    
    
}
