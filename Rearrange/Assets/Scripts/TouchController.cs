using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour
{
	[SerializeField]
	private TouchZone touchZone;

	// Use this for initialization
	void Start () 
  	{
		touchZone.OnTouchZonePointerUp += OnTouch;
	}
	
	private void OnTouch(Vector2 sourcePosition) 
  	{
    	//RaycastHit2D hit = Physics2D.Raycast(sourcePosition, 
	}
}