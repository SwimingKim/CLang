using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
	float delta = -0.1f;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
//		transform.position = new Vector3 (1,1,1);
		float newXPosition = transform.position.x + delta;
		transform.position = new Vector3 (newXPosition, 2, -7);
		if (transform.position.x < -3.5) {
			delta = 0.1f;
		} else if (transform.position.x > 3.5) {
			delta = -0.1f;
		}

	}
}
