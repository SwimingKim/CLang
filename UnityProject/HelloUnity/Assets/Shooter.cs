using UnityEngine;
using System.Collections;

public class Shooter : Obstacle {
	// 돌을 생성하는 기능
	public GameObject stone;

	// Use this for initialization
	float timeCount = 0;
	// Update is called once per frame
	void Update ()
	{
		base.Update ();
		timeCount += Time.deltaTime;
		if (timeCount > 3) {
			Debug.Log ("돌을 던져라");
			timeCount = 0;
			Instantiate (stone, transform.position, Quaternion.identity);
		}

	}
}
