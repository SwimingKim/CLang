using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	// start, update 로그로 찍기
	// 메소드 만들어서 실행해보기
	// 움직이는 거리 측정해보기
	// 콜라이더 값 변경
	// 스페이스바 누르면 점프

	int count = 1;
	float startingPoint;
	bool shouldPrintOver20 = true;
	bool shouldPrintOver30 = true;
	SphereCollider myCollider;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Start");
		TestMethod ();

		startingPoint = transform.position.z;

		Rigidbody myRigidbody = GetComponent<Rigidbody> ();
		Debug.Log ("UseGravity?:" + myRigidbody.useGravity);

		myCollider = GetComponent<SphereCollider> ();
	}

	// Update is called once per frame
	void Update ()
	{
//		Debug.Log ("Update " + count);
		count += 1;

		float distance;
		distance = transform.position.z - startingPoint;
//		Debug.Log (distance);
		if (distance > 30) {
			if (shouldPrintOver30) {
				Debug.Log ("Over 30: " + distance);
				shouldPrintOver30 = false;
			}
		} else if (distance > 20) {
			if (shouldPrintOver20) {
				Debug.Log ("Over 20: " + distance);
				shouldPrintOver20 = false;
			}
		}

//		myCollider.radius += .01f;

		if(Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log ("pressed");
			GetComponent<Rigidbody> ().AddForce (Vector3.up*300);
		}
	}

	void TestMethod ()
	{
		Debug.Log ("This is TestMethod");
	}
}
