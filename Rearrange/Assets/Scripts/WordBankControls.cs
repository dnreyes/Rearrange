using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class WordBankControls : MonoBehaviour {

	private bool drawWordBank = false;
	private static string wordToDisplay = "";
	private static string previousWord = "";
    private List<string> existingWords = new List<string>();

	public void Click() {
		//toggles between drawing and hiding word bank text
	    Debug.Log ("clicking");
		drawWordBank = !drawWordBank;
	}

	void OnGUI() {
        int scaley = Screen.height / 2;
		if (drawWordBank) {
			//only draws if the button is clicked.
                GUI.contentColor = Color.black;
                GUI.backgroundColor = Color.yellow;
                GUI.Box(new Rect(0, scaley, Screen.width, scaley), "Word Bank");
                GUI.Label(new Rect(10, (scaley + 10), Screen.width, scaley), previousWord);
		}
	}

	void LateUpdate() {
		//clearing the string for the next word
		previousWord = wordToDisplay;
	}

	public void AddWord(System.Object wordToAdd) {
		//adds the word to the wordbank ONLY if the word has not
        //been used yet. Ignores the word if it has.
        if (existingWords.IndexOf(wordToAdd.ToString().ToLower()) == -1)
        {
            wordToDisplay = previousWord + wordToAdd.ToString().ToLower() + "\n";
            Debug.Log(wordToDisplay);
            existingWords.Add(wordToAdd.ToString());
        }
	}
}
