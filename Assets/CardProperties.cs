using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardProperties : MonoBehaviour {

	float CurrentRotation;
	public float incrementDelta, newcurr, x, y ,z;

	// Use this for initialization
	void Start () {
		CurrentRotation = transform.rotation.eulerAngles.y;
		incrementDelta = 0.0f;
		CardFlip ();
	}
	
	// Update is called once per frame
	void Update () {
		x = transform.rotation.eulerAngles.x;
		y = transform.rotation.eulerAngles.y;
		z = transform.rotation.eulerAngles.z;

		incrementDelta += (Time.deltaTime / 10.0f);

		if(gameObject.transform.rotation.eulerAngles.y < (CurrentRotation +180f) )
		{
			transform.Rotate(0.0f,(Mathf.Sin (Mathf.Lerp(0.0f, Mathf.PI,incrementDelta))/10.0f),0.0f);
		}
	}

	void CardFlip()
	{
		float CurrentRotation = gameObject.transform.rotation.eulerAngles.y;



	}

}
