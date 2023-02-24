using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Learning_Curve : MonoBehaviour
{
    public Text outputText;
    public int CurrentAge;
    public int AddedAge;
    public string myName;

    public float Pi = 3.14f;
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(30 + 1);
        outputText.text = "30 + 1" + "\n";
        Debug.Log(CurrentAge + 1);
        outputText.text += (CurrentAge + 1).ToString() + "\n";

        ComputeAge();
        SayMyName();
        GenerateCharacter("Spike", 50);

        int NextSkillLevel = GenerateCharacter("Spike", 50);

        Debug.Log(NextSkillLevel);
        outputText.text += "\n" + NextSkillLevel.ToString();
        Debug.Log(GenerateCharacter("Faye", 60));
        outputText.text += "\n" + GenerateCharacter("Faye", 60);
    }

    void ComputeAge()
    {
        int localX = 10;

        Debug.Log(CurrentAge + AddedAge);
        outputText.text += (CurrentAge + AddedAge);
        Debug.Log($"A string can have variables like {myName} insterted directly");
        outputText.text += $"\nA string can have variables like {myName} insterted directly";
    }

    public void SayMyName()
    {
        Debug.Log("My name is " + myName);
        outputText.text += "\n" + "My name is " + myName;
    }

    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level {1} ", name, level);
        outputText.text += $"\nCharacter: {name} - Level: {level}";
        outputText.text += "\nCharacter: Spike";
        return level += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
