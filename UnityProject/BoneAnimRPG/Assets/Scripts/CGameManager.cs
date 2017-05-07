using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CGameManager : MonoBehaviour {

    public Text _scoreText;

	// 운석 점수를 점수판에 반영함
	public void ScoreUp(int score)
	{
        int totalScore = int.Parse(_scoreText.text);
        totalScore += score;
        _scoreText.text = totalScore.ToString();

        // PlayerPrefs에 SCORE란 이름으로 점수를 저장함
        PlayerPrefs.SetString("SCORE", _scoreText.text);
        PlayerPrefs.Save();
    }

	public void EndGame()
	{
        // 게임 종료씬으로 이동함
        SceneManager.LoadScene("End");
    }

}
