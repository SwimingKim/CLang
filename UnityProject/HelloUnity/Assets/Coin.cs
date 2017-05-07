using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
	// 코인 충돌 시 사라지기
	// 게임 매니저로부터 메소드 불러오기
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.name == "Ball") {
			GameObject.Find ("GameManager").SendMessage ("GetCoin");
			Destroy (gameObject);
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
