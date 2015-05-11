using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SampleDoor : MonoBehaviour {

	public Text displayText;
	public bool displayed = false;

	void OnMouseDown(){
		print("YELLOW");
		if (!displayed) {
			displayText.text = displayText.text + "\nyellow";
			displayed = true;
		}
	}
}



