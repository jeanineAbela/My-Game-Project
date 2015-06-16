
using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// add a refernce to the style
	public GUISkin style;


	//added GUI to menu controller
	void OnGUI ()
	{
		
		// add the skin to the gui
		GUI.skin = style;
		
		// create a label with the name of the game
		GUI.Label (new Rect (Screen.width / 2 - 100f, Screen.height / 2 - 50f, 200f, 100f), "Penguin and Obstacles!");
		
		//load the main game
		if (GUI.Button (new Rect (Screen.width / 2 - 100f, Screen.height / 2 + 35f, 200f, 50f), "PLAY")) {
			//Load the main menu scene which is 1 in the BUILD SETTINGS			
			Application.LoadLevel (1);
		}

		//load the how to play scene
		if (GUI.Button (new Rect (Screen.width / 2 - 100f, Screen.height / 2 + 90f, 200f, 50f), "How to Play")) {
			//Load the how to play scene which is 6 in the BUILD SETTINGS			
			Application.LoadLevel(6);
		}
		
		
	}


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

}

