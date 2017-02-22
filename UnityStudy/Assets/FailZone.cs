using UnityEngine;
using System.Collections;

public class FailZone : MonoBehaviour
{
	// 게임 매니저로부터 메소드 불러오기
	void OnTriggerEnter (Collider collider)
	{
		Debug.Log (collider.gameObject.name);
		if (collider.gameObject.name == "Ball") {
			GameObject.Find ("GameManager").SendMessage ("RestartGame");
		}
	}

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}
}
