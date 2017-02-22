using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	// 전체 게임을 관리하는 게임관리자
	int coinCount = 0;

	void RestartGame() {
		Application.LoadLevel ("Game");
	}

	void RedCoinStart() {
		DestroyObstacles ();
	}

	void DestroyObstacles() {
		GameObject[] obstacles = GameObject.FindGameObjectsWithTag ("Obstacle");
		for(int i=0; i<obstacles.Length; i++){
			Destroy (obstacles[i]);
		}
	}

	void GetCoin() {
		coinCount++;

		Debug.Log ("동전 : "+coinCount);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
