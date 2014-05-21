using System;
using UnityEngine;

public class pause : MonoBehaviour
{
	bool paused = false;
	
	void Update()
	{
		if(Input.GetKeyDown("p"))
			paused = togglePause();
		if(Input.GetKeyDown("escape"))
			paused = togglePause();
		
	}





	void OnGUI()
	{


		GUI.Box (new Rect (5, 5, 150, 50), "Score: " + HealthScript.PlayerScore + "  Lives: " );



		if(paused)
		{
			GUI.Box (new Rect (5, 5, 150, 50), "Score: " + HealthScript.PlayerScore + "  Lives: ");
				if(GUI.Button(new Rect (160,5,100,50),"Pause"))
				paused = togglePause();
		}
	}
	
	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);    
		}
	}
}

