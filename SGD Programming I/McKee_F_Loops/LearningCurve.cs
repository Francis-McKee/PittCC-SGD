using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearningCurve : MonoBehaviour
{
    public Text outputText;
    List<string> questPartyMembers = new List<string>()
    {
        "Grim the Barbarian",
        "Merlin the Wise",
        "Sterling the Knight"
    };

    public Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
    {
        { "Potion", 5 },
        { "Antidote", 7 },
        { "Aspirin", 1 },
    };

    public int playerLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        outputText.text = "";

        for (int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);
            outputText.text += "\nIndex: " + i + " - " + questPartyMembers[i];

            if (questPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
                outputText.text += "\nGlad you're here Merlin!";
            }
        }

        foreach(string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
            outputText.text += "\n" + partyMember + " Here!";
        }

        foreach (KeyValuePair<string, int> kvp in ItemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
            outputText.text += "\nItem: " + kvp.Key + " " + kvp.Value + "g";
        }

        HealthStatus();
    }

    public void HealthStatus()
    {
        while(playerLives > 0)
        {
            outputText.text += "\nStill alive!";
            Debug.Log("Still Alive");
            playerLives--;
        }
        outputText.text += "\nThe Valkyrie has died!";
    }


    // Update is called once per frame
    void Update()
    {
        
    }


}
