using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Response : MonoBehaviour
{
    public bool IsCorrect;

    public void Answer()
    {
        GameManager.sGameManager.Response(IsCorrect);
    }

}
