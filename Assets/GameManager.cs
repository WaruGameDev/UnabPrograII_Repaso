using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager sGameManager;
    public List<Question> preguntas;
    public QuestionLoader questionLoader;
    public int puntaje;
    public int index;

    private void Awake()
    {
        sGameManager = this;
    }

    public void Response(bool answer)
    {
        if(answer)
        {
            sGameManager.puntaje += 100;
            Debug.Log(sGameManager.puntaje);
        }
        else
        {
            Debug.Log("Te equivocaste");
        }
        index++;
        ShowNextQuestion();
    }
    public void ShowNextQuestion()
    {
        questionLoader.question = preguntas[index];
        questionLoader.ShowQuestion();
    }
    private void Start()
    {
        ShowNextQuestion();
    }

}
