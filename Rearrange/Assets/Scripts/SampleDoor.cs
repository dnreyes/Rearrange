using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SampleDoor : MonoBehaviour {

	public Text displayText;
	public bool displayed = false;
	public GameObject prompt;

	void OnMouseDown(){
		print("YELLOW");
		if (!displayed) {
			displayText.text = displayText.text + "\nyellow";
			displayed = true;
		}

		if (prompt != null) {
			Tiles t = prompt.GetComponent<Tiles>();
			t.prompt += " yellow";
			t.displayPrompt(" yellow");
		}
	}
}



