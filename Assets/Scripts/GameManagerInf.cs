using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerInf : MonoBehaviour
{
    public float slowness = 10f;

    public void EndGame()
    {
        StartCoroutine(RestartLevel1());
    }

    IEnumerator RestartLevel1()
    { 
        //Time.timeScale = 1f / slowness;
        //Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1.2f);

        //Time.timeScale = 1f;
        //Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  

    }
}