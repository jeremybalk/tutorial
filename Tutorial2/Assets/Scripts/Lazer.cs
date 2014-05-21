using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour {

	private Transform MyTransform;
	
	public int LazerSpeed = 5;

	// Use this for initialization
	void Start () {
		
		MyTransform = transform;		
	}
	
	// Update is called once per frame
	void Update () {

		//Make the lazer shoot out and go up

		//gameobject = lazer = shoot-up

		MyTransform.Translate(Vector3.up * LazerSpeed);


		if (MyTransform.position.y > 5) 
		{
		
		}
}
}