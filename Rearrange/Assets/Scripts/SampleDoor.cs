using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SampleDoor : MonoBehaviour {

	public Text displayText;
//
//	void onMouseOver() {
//		if (Input.GetMouseButtonDown (0)) {
//			var hit : RaycastHit;
//			var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//			if (Physics.Raycast (ray, hit, 100.0))
//			{
//				SampleDoor = hit.collider.gameObject;
//				if(SampleDoor.Sample=="spritesheet_0")
//				{ 
//		print( "yellowwwwwwwwwwwwwwwwwwwwwwwwwwwww");
//			}
//		}
//
//		}
//	}
//
//	void Update(){
//		onMouseOver ();
//
//	}



	void OnMouseDown(){
		print("YELLOW");
	}

	void Update () {
		if (Input.GetMouseButton(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast(ray, out hit)) {
				print("Yellow");
			} else {
				print("Hit nothing");
			}
		}
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
