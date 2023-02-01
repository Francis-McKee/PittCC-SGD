using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearningCurve : MonoBehaviour
{
    public Text outputText;
    public int CurrentAge = 30;
    public int AddedAge;
    int PrivAge;
    public string myName;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(30 + 1);
        outputText.text = "30 + 1" + "\n";
        Debug.Log(CurrentAge + 1);
        outputText.text += (CurrentAge + 1).ToString() + "\n";

        ComputeAge();
        SayMyName();
    }

    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
        outputText.text += (CurrentAge + AddedAge);
    }

    public void SayMyName()
    {
        Debug.Log("My name is " + myName);
        outputText.text += "\n" + "My name is " + myName;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
