using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
	// 양 가운데에 향하면 위치 바꾸기
	// 글로벌이 아닌 로컬변수 따라가기
	float delta = -0.1f;
	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
//		transform.position = new Vector3 (1,1,1);
		float newXPosition = transform.localPosition.x + delta;
		transform.localPosition = new Vector3 (newXPosition, transform.localPosition.y, transform.localPosition.z);
		if (transform.localPosition.x < -3.5) {
			delta = 0.1f;
		} else if (transform.localPosition.x > 3.5) {
			delta = -0.1f;
		}

	}
}
