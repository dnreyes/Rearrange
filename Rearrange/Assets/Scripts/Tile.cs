using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	private int size = 5;

	public char tilename;
	//public int xpos;
	//public int ypos;

	private Vector3 screenPoint; 
	private Vector3 offset; 
	private float _lockedYPosition;

	void OnMouseDrag()
	{
		Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		point.z = gameObject.transform.position.z;
		gameObject.transform.position = point;
		Cursor.visible = false;
	}
	
	void OnMouseUp()
	{
		Cursor.visible = true;
	}
}
