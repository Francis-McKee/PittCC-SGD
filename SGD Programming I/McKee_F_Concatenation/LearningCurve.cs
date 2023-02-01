using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LearningCurve : MonoBehaviour
{
    public Text outputText;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Again!");
        outputText.text = "Hello Again!\n";
        Debug.Log("I'm in SGD 113!");
        outputText.text += "I'm in SGD 113!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
