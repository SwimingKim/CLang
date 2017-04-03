using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{
	// 화살표를 누르면 각도 회전
	// 왼쪽과 오른쪽을 클릭하면 각도 회전

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		float zRotation = transform.localEulerAngles.z;
		zRotation -= Input.GetAxis ("Horizontal");
//		Debug.Log(Input.GetAxis ("Horizontal"));
		transform.localEulerAngles = new Vector3 (10, 0, zRotation);

		if (Input.touchCount > 0 || Input.GetMouseButton (0)) {
//			Debug.Log ("mouse down: "+Input.mousePosition);
			if (Input.mousePosition.x < Screen.width / 2) {
				transform.localEulerAngles = new Vector3 (10, 0, transform.localEulerAngles.z + 1);
			} else {
				transform.localEulerAngles = new Vector3 (10, 0, transform.localEulerAngles.z - 1);
			}
		}

	}
}
