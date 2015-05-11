using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class TextInput: MonoBehaviour {

	private string sInput;
	public Text tInput;
	public InputField iInput;
	public Animation anim;


	// Update is called once per frame
	void Update () {
		//anim = GetComponent<Animation>();
		//anim.Stop ();
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
