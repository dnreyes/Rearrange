using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SampleDoor : MonoBehaviour {

	public Text displayText;
//
	void onMouseOver() {
		if (Input.GetMouseButtonDown (0)) {
			print( "yellowwwwwwwwwwwwwwwwwwwwwwwwwwwww");
		}

	}
	void Update(){
		onMouseOver ();

	}
//	function OnMouseDown(){
//			Debug.log ("YEELLLOW OMG PRINT YELLOW");
//
//	}




//	void Update () {
//		if (Input.GetKeyDown ("return")) {
//
//			tInput.text = "Yay you won!";
//		}
//	}
//}
}
