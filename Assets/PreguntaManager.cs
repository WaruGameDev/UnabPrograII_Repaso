using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaManager : MonoBehaviour
{
    public static PreguntaManager sPreguntaManager;
    public CargaPregunta cargaPregunta;
    public List<Pregunta> preguntas;
    public int index;
    public int puntaje;

    private void Awake()
    {
        sPreguntaManager = this;
    }

    public void Responder(bool respuestaCorrecta)
    {
        if(respuestaCorrecta)
        {
            sPreguntaManager.puntaje += 200;
        }
        else
        {
            print("wrong");
        }
        index++;
        ShowNextQuestion();
    }

    public void ShowNextQuestion()
    {
        cargaPregunta.pregunta = preguntas[index];
        cargaPregunta.ShowQuestion();
    }
    private void Start()
    {
        ShowNextQuestion();
    }


}
