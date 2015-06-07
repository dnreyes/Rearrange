using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Solution : MonoBehaviour{
	public List<GameObject> answer = new List<GameObject>();
	public string finalAnswer = "";

	//get tilename from children
	public string updateAnswer() {
		finalAnswer = "";
		for (int i = 0; i < this.transform.childCount; i++) {
			Draggable child = this.transform.GetChild(i).gameObject.GetComponent<Draggable>();
			if (child != null) {
				char c = child.tilename;
				finalAnswer += c;
			} 
		}
		return finalAnswer;
	}

	public void destroyTiles() {
		for (int i = 0; i < this.transform.childCount; i++) {
			Destroy(this.transform.GetChild(i).gameObject);
		}
	}
}