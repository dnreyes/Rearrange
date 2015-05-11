using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class TextInput: MonoBehaviour {

	private string sInput;
	public Text tInput;
	public InputField iInput;
	public Animation anim;

<<<<<<< HEAD
	//access Level1 stuff for animations

=======
	//get input from text field
	//print input into textbox after pressing enter
    void Start()
    {
        sInput = "";
    }
>>>>>>> origin/master
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

<<<<<<< HEAD
        if (sInput != null) { //<-- yay no errors!
			//do something
		}
=======
        if (sInput.Equals("hole"))
        {
            tInput.text = "Yay! You Won!";
        }
>>>>>>> origin/master
	}
}
