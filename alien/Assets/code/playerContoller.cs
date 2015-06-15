
using UnityEngine;
using System.Collections;

public class playerContoller : MonoBehaviour
{

	
		// create a public variable for the GUI skin
		public GUISkin style;
	
		// create a public variable for the number of lives
		public int lives;
	
		// declare a variable for the animator
		Animator anim;
	
		// declare a boolean jump
		bool jump;
	
		// Declare a variable for the current time
		float currentTime;
	
		// Declare a variable for the start time
		float startTime;

		// create the OnGUI method
		void OnGUI ()
		{
				// add the skin to the gui
				GUI.skin = style;




				// format minutes
				string minutes = Mathf.Floor (currentTime / 60).ToString ("00");

				// format seconds
				string seconds = Mathf.Floor (currentTime % 60).ToString ("00");

				// create a label 10 to the right and 10 further down from the top left corner
				GUI.Label (new Rect (10f, 10f, 150f, 30f), "Lives: " + lives);
		
				// output the minutes : seconds
				GUI.Label (new Rect (10f, 40f, 150f, 30f), minutes + ":" + seconds);
		
				// show the level.  show the scene name on screen
				GUI.Label (new Rect (10f, 70f, 150f, 30f), Application.loadedLevelName);

				//add a quit button at the TOP of the screen
		GUI.Button (new Rect (Screen.width / 2 - 100f, 25f, 200f, 25f), "QUIT"); 
					
					
	}
	
	//Collision function between penguin and obstacle
		void OnTriggerEnter2D (Collider2D otherObject)
		{
				// check the tag of the object I hit.  if it is an obstacle..
				if (otherObject.tag == "obstacle") {

						// destroy the obstacle
						Destroy (otherObject.gameObject);

						// reduce lives by 1
						lives--;

						// if lives are 0
						if (lives == 0) {

								//game over, go to game over screen
								Application.LoadLevel ("gameover");
						}
				}
		}



	
	
	// Use this for initialization
		void Start ()
		{
				// assign the animator according to the animator component in the player
				anim = GetComponent<Animator> ();
		
				//save the time when I pressed play to start the game
				startTime = Time.time;


		
		}

		//jump the penguin upwards for 0.5 seconds
		IEnumerator jumpBox ()
		{
				// Set the position of the penguin to jumped
				transform.position = new Vector3 (-5f, -1f, 0f);
		
				// the jump animation will become true
				jump = true;

				//set the animator parameter
				anim.SetBool ("Jump", jump);

				//Wait for 0.5 seconds
				yield return new WaitForSeconds (0.8f);

				// set jump = false
				jump = false;

				// set the animator parameter again
				anim.SetBool ("Jump", jump);
		
				// Set the position of the player to normal
				transform.position = new Vector3 (-5f, -3f, 0f);
		
		}

		//jump the penguin upwards for 0.5 seconds
		IEnumerator duckBox ()
		{
				//Set the position of the penguin to jumped
				transform.position = new Vector3 (-5f, -5f, 0f);
		
				// the jump animation will become true
				jump = true;

				//set the animator parameter
				anim.SetBool ("Jump", jump);

				// Wait for 0.5 seconds
				yield return new WaitForSeconds (0.8f);

				// set jump = false
				jump = false;

				// set the animator parameter again
				anim.SetBool ("Jump", jump);
		
				//Set the position of the player to normal
				transform.position = new Vector3 (-5f, -3f, 0f);
		
		}
		// Update is called once per frame
		void Update ()
		{
				//Calculate how long I have been playing for in milliseconds
				currentTime = Time.time - startTime;

		
				// After 30 seconds,in level1 go to level2 window
				if (currentTime > 30 && Application.loadedLevelName == "level1") {
					//43. Load win window
					Application.LoadLevel ("level2");
				}

				//After 30 seconds,in level2 go to level3 window
				if (currentTime > 30 && Application.loadedLevelName == "level2") {
						//43. Load win window
						Application.LoadLevel ("level3");
				}

				//After 30 seconds,in level3 go to win window
				if (currentTime > 30 && Application.loadedLevelName == "level3") {
					//43. Load win window
					Application.LoadLevel ("win");
				}

	
		
		
		//if the mouse is clicked, set jump to true
				if (Input.GetMouseButtonDown (0)) {
			
			
						//jump 
						StartCoroutine ("jumpBox");
			
			
				}

				if (Input.GetMouseButtonDown (1)) {

						StartCoroutine ("duckBox");
				}
		
		}

}

