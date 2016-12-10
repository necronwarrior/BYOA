using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardProperties : MonoBehaviour {

	float CurrentRotation;
	string[] CardStats;
	public float incrementDelta, newcurr, x, y ,z;

	// Use this for initialization
	void Start () {
		SetCard ("Test");
	}

	void SetCard(string CardName)
	{
		CardStats = new string[5];
				CardStats = FileRead.use.CardFind (CardName);
		z = transform.rotation.eulerAngles.z;
	}

	// Update is called once per frame
	void Update () {
		x = transform.rotation.eulerAngles.x;
		y = transform.rotation.eulerAngles.y;
		z = transform.rotation.eulerAngles.z;

		incrementDelta += (Time.deltaTime / 10.0f);
	}

	void OnMouseDown(){
		StartCoroutine(MoveObject.use.Rotation (transform, Vector3.up*180.0f, 1.0f));
	}
}
