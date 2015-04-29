using UnityEngine;
using System.Collections;

public class WindCharacter : MonoBehaviour
{
	[SerializeField]
	private WindPad windPad;

	[SerializeField]
	private float windStrength;

	[SerializeField]
	private Rigidbody2D mainCharacter;

	// Use this for initialization
	void Start ()
	{
		windPad.OnWindPadPointerUp += OnWindImpulse;
	}
	
	private void OnWindImpulse(Vector2 windSourcePosition) {
		Vector2 windDir = ((Vector2)mainCharacter.transform.position - windSourcePosition).normalized;
			
		mainCharacter.AddForce(windDir * windStrength);
	}
}

