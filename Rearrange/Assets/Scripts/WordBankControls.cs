using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class WordBankControls : MonoBehaviour {

	private bool drawWordBank = false;
	private static string wordToDisplay = "";
	private static string previousWord = "";
    private List<string> existingWords = new List<string>();

	//slides from 570 (hiding) to 270 (showing)
	private float offset = 570f;

	void OnMouseDown() {
		//toggles between drawing and hiding word bank text
		//Debug.Log ("clicking");
		drawWordBank = !drawWordBank;
		Debug.Log (drawWordBank);
	}

	void OnGUI() {
		if (drawWordBank) {
			//StartCoroutine(SlideIn());
			//only draws if the button is clicked.
			GUI.contentColor = Color.black;
			GUI.backgroundColor = Color.yellow;
			GUI.Box (new Rect(0, 100, 800, 300), "Word Bank");
			GUI.Label (new Rect (10, 110, 800, 300), previousWord );
		}
	}

	public void LateUpdate() {
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

	IEnumerator SlideIn() {
		for (int i = -10; i < 0; ++i) {
			offset = 10 * i;
			yield return new WaitForSeconds (0.1f);
		}
		offset = 570f;
	}
}
