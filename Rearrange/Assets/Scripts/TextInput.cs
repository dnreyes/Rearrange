using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class TextInput: MonoBehaviour {

	private string sInput;
	public Text tInput;
	public InputField iInput;

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("return")) {
			//set the text field to be user input
			tInput.text = iInput.text;
			//save user input in a string
		    sInput = iInput.text;
		}

        if (sInput != null) { //<-- yay no errors!
			//do something
		}
	}
}
