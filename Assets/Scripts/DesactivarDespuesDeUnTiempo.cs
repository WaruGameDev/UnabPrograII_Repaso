using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarDespuesDeUnTiempo : MonoBehaviour
{
    public float totalTime = 3;
    public float currentTime;
    // Start is called before the first frame update
    private void OnEnable()
    {
        currentTime = totalTime;
        StartCoroutine(Contador());
    }

    IEnumerator Contador()
    {
        while(currentTime > 0)
        {
            yield return new WaitForSeconds(1);
            currentTime--;
        }
        gameObject.SetActive(false);

        yield break;
    }
}
