using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	// 전체 게임을 관리하는 게임관리자
	// public 변수 선언
	public int coinCount = 0;
	public Text coinText;

	public void RestartGame() {
		Application.LoadLevel ("Game");
	}

	public void RedCoinStart() {
		DestroyObstacles ();
	}

	public void DestroyObstacles() {
		GameObject[] obstacles = GameObject.FindGameObjectsWithTag ("Obstacle");
		for(int i=0; i<obstacles.Length; i++){
			Destroy (obstacles[i]);
		}
	}

	public void GetCoin() {
		coinCount++;
		coinText.text = coinCount + "개";
		Debug.Log ("동전 : "+coinCount);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Debug.Log (coinCount);
	}
}
