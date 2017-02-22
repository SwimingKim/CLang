using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
	// 양 가운데에 향하면 위치 바꾸기
	// 글로벌이 아닌 로컬변수 따라가기
	// 거리계산 메소드를 만들어서 활용하기
	// collision 충돌

	void TestMethod (string name)
	{
		float distance = Vector3.Distance (GameObject.Find(name).transform.position,
			transform.position);
		Debug.Log (name + "까지 거리 : " + distance);
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.gameObject.name);
		Vector3 direction = transform.position - collision.gameObject.transform.position;
		Debug.Log (direction);
		direction = direction.normalized * -500;
		Debug.Log (direction);
		collision.gameObject.GetComponent<Rigidbody> ().AddForce (direction);
	}

	float delta = -0f;
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
//		TestMethod ("Ground");
	}
}
