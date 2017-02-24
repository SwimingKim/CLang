using UnityEngine;
using System.Collections;

public class FailZone : MonoBehaviour
{
	// 게임 매니저로부터 메소드 불러오기
	// 게임매니저 클래스 사용
	void OnTriggerEnter (Collider collider)
	{
		Debug.Log (collider.gameObject.name);
		if (collider.gameObject.name == "Ball") {
//			GameObject.Find ("GameManager").SendMessage ("RestartGame");
//			GameObject gm = GameObject.Find("GameManager");
//			GameManager gmComponent = gm.GetComponents<GameManager>();
			GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
			gmComponent.RestartGame ();
		}
	}

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
//		Debug.Log(gmComponent.coinCount);
	}
}
