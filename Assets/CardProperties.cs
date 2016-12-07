using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardProperties : MonoBehaviour {

	float CurrentRotation;
	public float incrementDelta, newcurr;

	// Use this for initialization
	void Start () {
		CurrentRotation = transform.rotation.eulerAngles.y;
		incrementDelta = 0.0f;
		CardFlip ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CardFlip()
	{
		float CurrentRotation = gameObject.transform.rotation.eulerAngles.y;
		float incrementDelta = 0.0f;

		while(gameObject.transform.rotation.eulerAngles.y < (CurrentRotation +180f) )
		{
			incrementDelta += Time.deltaTime;
			transform.Rotate(transform.rotation.eulerAngles.x, 
				Mathf.LerpAngle (transform.rotation.eulerAngles.y, 
					(CurrentRotation + 180f),
					Time.time),
				transform.rotation.eulerAngles.z);
		}

	}

}
