using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Question", menuName = "WalterTrabajo/Question", order = 1)]
public class Question : ScriptableObject
{
    public string textoPregunta;
    public string respuestaCorrecta;
    public List<string> otrasRespuestas;    
}
