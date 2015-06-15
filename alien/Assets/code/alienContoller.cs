using UnityEngine;
using System.Collections;

public class alienContoller : MonoBehaviour
{

		// set a public variable for speed
		public float obstacleSpeed;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
		
				// move the obstacle to the left
				// obstacleSpeed 
				transform.Translate (new Vector3 (-1f, 0f, 0f) * 6f * Time.deltaTime);
		
				// if the x position is less than -7, delete the obstacle
				if (transform.position.x < -7) {
						Destroy (this.gameObject);
				}
		}
}
