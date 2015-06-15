using UnityEngine;
using System.Collections;

public class alienGeneratorController : MonoBehaviour
{

		//16. public gameobject variable for obstacle
		public GameObject[] obstacles;
	
	
		//17. declare a variable for the time gap
		float timeGap;

		//18. create a coroutine to generate obstacles
		IEnumerator generateObstacles ()
		{
				//19. the coroutine runs forever
				while (true) {
						//21. Random time gap
						timeGap = Random.Range (1f, 3f);
			
						//49. create an obstacle
						int obstacleChooser = (int)Mathf.Floor (Random.Range (0f, 2f));
			
						//50.
						Debug.Log (obstacleChooser);

						float height = 0f;

						if (obstacleChooser == 1f) {
								height = -3.5f;
						} else {
								height = -2f;
						}


						Instantiate (obstacles [obstacleChooser], new Vector3 (7f, height, 0f), Quaternion.identity);
			
						//20. has a random time gap
						yield return new WaitForSeconds (timeGap);
				}
		}


		// Use this for initialization
		void Start ()
		{
				//23. start the coroutine that generates the obstacles immediately
				StartCoroutine ("generateObstacles");
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
