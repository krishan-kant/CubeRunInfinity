using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highS : MonoBehaviour
{
    public static int currScor1 = 0;
    Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = GetComponent<Text>();
        highScore.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        currScor1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currScor1 > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", currScor1);
            highScore.text = currScor1.ToString();
        }
    }
}
