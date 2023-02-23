using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearningCurve : MonoBehaviour
{
    public Text outputText;

    public bool hasDungeonKey = true;
    public int CurrentGold = 32;
    public string weaponType = "Longsword";
    public bool weaponEquipped = true;

    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "Relic Stone";

    // Start is called before the first frame update
    void Start()
    {
        //hasDungeonKey = false;
        outputText.text = "";

        if(hasDungeonKey)
        {
            Debug.Log("You pressed the sacred key - enter.");
            outputText.text += "You pressed the sacred key - enter.";
        }

        /*
        else
        {
            Debug.Log("You have not proved yourself yet.");
            outputText.text += "\nYou have not proved yourself yet.";
        }
        */

        if(!hasDungeonKey)
        {
            Debug.Log("You may not enter without the sacred key");
            outputText.text += "\nYou may not enter without the sacred key";
        }

        if(weaponType != "Longsword")
        {
            Debug.Log("You don't appear to have the right type of weapon...");
            outputText.text += "\nYou don't appear to have the right type of weapon";
        }

        if(weaponEquipped && weaponType == "Longsword")
        {
            Debug.Log("For the Queen!");
            outputText.text += "\nFor the Queen!";
        }
        else
        {
            Debug.Log("Fists aren't going to work against armor...");
            outputText.text += "\nFists aren't going to work against armor...";
        }

        Thievery();
        OpenTreasureChamber();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Thievery()
    {
        if (CurrentGold > 50)
        {
            Debug.Log("You're rolling in it!");
            outputText.text += "\nYou're rolling in it!";
        }
        else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
            outputText.text += "\nNot much left there to steal...";
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
            outputText.text += "\nLooks like your purse is in the sweet spot.";
        }
    }

    public void OpenTreasureChamber()
    {
        if(pureOfHeart && rareItem == "Relic Stone")
        {
            if(!hasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
                outputText.text += "\nYou have the spirit but not the knowledge.";
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
                outputText.text += "\nThe treasure is yours, worthy hero!";
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
            outputText.text += "\nCome back when you have what it takes.";
        }
    }
}
