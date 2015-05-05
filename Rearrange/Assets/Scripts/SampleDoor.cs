using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SampleDoor : MonoBehaviour {

	public Text displayText;

	void onMouseOver() {
		if (Input.GetMouseButtonDown (0)) {
			displayText.text = "yellow";
		} else {
			print ("poop");
		}
	}

}
