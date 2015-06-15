using UnityEngine;
using System.Collections;

public class alienGeneratorController : MonoBehaviour
{

		// public gameobject variable for obstacle
		public GameObject[] obstacles;
	
	
		// declare a variable for the time gap
		float timeGap;

		// create a coroutine to generate obstacles
		IEnumerator generateObstacles ()
		{
				// the coroutine runs forever
				while (true) {
						// Random time gap
						timeGap = Random.Range (1f, 3f);
			
						// create an obstacle
						int obstacleChooser = (int)Mathf.Floor (Random.Range (0f, 2f));
			
						//
						Debug.Log (obstacleChooser);

						float height = 0f;

						if (obstacleChooser == 1f) {
								height = -3.5f;
						} else {
								height = -2f;
						}


						Instantiate (obstacles [obstacleChooser], new Vector3 (7f, height, 0f), Quaternion.identity);
			
						// has a random time gap
						yield return new WaitForSeconds (timeGap);
				}
		}


		// Use this for initialization
		void Start ()
		{
				// start the coroutine that generates the obstacles immediately
				StartCoroutine ("generateObstacles");
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
