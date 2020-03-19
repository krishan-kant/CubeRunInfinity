using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currS : MonoBehaviour
{

    public static int currScor = 0;
    Text currentS;

    // Start is called before the first frame update
    void Start()
    {
        currentS = GetComponent<Text> ();
        currentS.text = "0";
        currScor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentS.text = "" + currScor;
    }
}
