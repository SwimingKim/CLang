using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CEndManager : MonoBehaviour {

    public Text _starText;

	void Start()
	{
        _starText.text = PlayerPrefs.GetString("SCORE", "0");
    }

    public void OnRestartButtonClick()
	{
        SceneManager.LoadScene("Game");

        // 게임 초기화
        CGameManager._bombState = 2;
        Destroy(GameObject.Find("Ground"));
    }

}
