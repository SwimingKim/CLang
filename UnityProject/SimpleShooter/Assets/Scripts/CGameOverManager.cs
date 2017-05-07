using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// UI 사용
using UnityEngine.UI;
// 씬 관리 사용
using UnityEngine.SceneManagement;

public class CGameOverManager : MonoBehaviour {

	public Text _textScoreText; // 최종 시간(점수) 출력

	// Use this for initialization
	void Start () {
		_textScoreText.text = CGameManager.time.ToString();
		CGameManager.time = 0;
	}

	// 재시작 버튼을 누르면
	public void OnReStartButtonClick()
	{
		SceneManager.LoadScene("Game"); // Game씬으로 이동
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
