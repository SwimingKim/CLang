using UnityEngine;
using System.Collections;

public class RedCoin : MonoBehaviour {
//게임 매니저로부터 메소드 불러오기

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.name == "Ball") {
			Destroy (gameObject);
			GameObject.Find ("GameManager").SendMessage ("RedCoinStart");
		}

	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
