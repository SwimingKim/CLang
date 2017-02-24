using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour
{
	// failZone처럼 게임 재시작
	// 공의 위치에 따라 이동 및 회전
	Vector3 target;

	void OnTriggerEnter (Collider collider)
	{
		Debug.Log (collider.gameObject.name);
		if (collider.gameObject.name == "Ball") {
			GameManager gmComponent = GameObject.Find ("GameManager").GetComponent<GameManager> ();
			gmComponent.RestartGame ();
		}
	}

	// Use this for initialization
	void Start ()
	{
		target = GameObject.Find ("Ball").transform.position;
	}

	// Update is called once per frame
	void Update ()
	{
		transform.position = Vector3.MoveTowards (transform.position, target, 0.1f);
		transform.Rotate (new Vector3 (0, 0, 5));
	}
}
