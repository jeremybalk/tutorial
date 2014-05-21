using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Transform MyTransform;

	public int PlayerSpeed = 5;
	// Use this for initialization
	void Start () {

		MyTransform = transform;
		//spawn point		 x	y	z
		// position to be at -3 -3 -1

		MyTransform.position = new Vector3(-3, -3 -1);
		


	}
	
	// Update is called once per frame
	void Update () {
	
		//move player left and right
		MyTransform.Translate (Vector3.right * PlayerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
		//move player up and down
		MyTransform.Translate (Vector3.up * PlayerSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

		// world borders
	
		if(MyTransform.position.x > 16)
		{
			MyTransform.position = new Vector3(16, MyTransform.position.y, MyTransform.position.z);
		}
		else if(MyTransform.position.x < -16)
		{
			MyTransform.position = new Vector3(-16, MyTransform.position.y, MyTransform.position.z);
		}

		if(MyTransform.position.y > 5)
		{
			MyTransform.position = new Vector3(MyTransform.position.x, 5, MyTransform.position.z);
		}
		else if(MyTransform.position.y < -5)
		{
			MyTransform.position = new Vector3(MyTransform.position.x, -5, MyTransform.position.z);
		}

		//Fire the lazerzzzzz!!!!!
		//If the player presses the spacebar, the lazerzzzzz!!!!! will fire


	}
}
