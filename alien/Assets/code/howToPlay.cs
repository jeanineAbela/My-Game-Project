using UnityEngine;
using System.Collections;

public class howToPlay : MonoBehaviour
{
		// add a refernce to the style
		public GUISkin style;
	
	
		//added GUI to menu controller
		void OnGUI ()
		{
		
				// add the skin to the gui
				GUI.skin = style;
		
				
		
				//load the how to play scene
				if (GUI.Button (new Rect (Screen.width / 2 - 100f, Screen.height / 2 + 100f, 200f, 50f), "Go Back")) {
						//Load the main scene which is 0 in the BUILD SETTINGS			
						Application.LoadLevel (0);
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
