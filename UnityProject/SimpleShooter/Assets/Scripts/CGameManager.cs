using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// UI 사용
using UnityEngine.UI;

public class CGameManager : MonoBehaviour {

	public Text _timerText; // 타이머 텍스트
	public static int time = 0; // 플레이 시간 (스태틱)

	// Use this for initialization
	void Start () {
		InvokeRepeating("Timer", 0, 1); // 1초마다 타이머가 동작함
	}

	// 타이머
	void Timer()
	{
		_timerText.text = (++time).ToString();
	}

}
