using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 씬 관리
using UnityEngine.SceneManagement;

// UI 사용
using UnityEngine.UI;

public class CGameManager : MonoBehaviour {

	// 게임 종료 여부
    public static bool isGameStop = false;

    public Text _startCountText;

    public Animator _backgroudAnim; // 배경 애니메이터

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CGameManager.isGameStop)
		{
			// 배경의 애니메이션의 재생 속도를 0으로
            _backgroudAnim.speed = 0f;
        }
	}

	// 점수 증가
	public void ScoreUp()
	{
		string strCount = _startCountText.text;
		// int.Parse(string) : 문자열(string) -> 정수(int)
        int count = int.Parse(strCount);
        count++;
		// int.ToString() : 정수 -> 문자열(string)
        _startCountText.text = count.ToString();

        BestScoreSave(); // 현재 점수를 판단하여 최고 점수로 저장함
    }

	// 최고 점수 저장
	public void BestScoreSave()
	{
        string strBestCount = PlayerPrefs.GetString("BEST_SCORE", "0");
        int bestCount = int.Parse(strBestCount);

        string strCount = _startCountText.text;
        int count = int.Parse(strCount);

		// 현재 획득한 점수가 저장된 최고 점수보다 크다면
		if (bestCount > count)
		{	
			// 최고 점수를 갱신하라
            PlayerPrefs.SetString("BEST_COUNT", count.ToString());
            PlayerPrefs.Save();
        }

    }

	public void GameEnd()
	{
		// End 씬으로 이동
        SceneManager.LoadScene("End");
    }

}
