using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class TextInput: MonoBehaviour {

	private string sInput;
	public Text tInput;
	public InputField iInput;

	//get input from text field
	//print input into textbox after pressing enter


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("return")) {
			//set the text field to be user input
			tInput.text = iInput.text;
			//save user input in a string
			sInput = iInput.text;
		}
		else if (sInput.Equals("hole")) {
			// set the text field to win state
			tInput.text = "yay! you won!";
		}
	}
}
