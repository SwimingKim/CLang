using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CGameManager : MonoBehaviour {

	public static bool isGameover = false;
    public Text _timeText;
    public Text _descriptionText;
    public Text _carrotText;
    public Text _bestText;

    public int _gameTime = 3;
    public GameObject _rabitPrefab;
    public Image[] _gameElement;
    int carrot = 0, bestCount;

    public GameObject _bubble;

    void Start () {
        InvokeRepeating("GameStart", 0, 1);
    }

	int pos = 0;
    string[] gameDescription = { "우리 토끼는 하늘을 날 수 있어요", "산토끼의 반대말은 뭘까요??", "컨트롤키를 누르면 공격할 수 있어요", "토끼를 움직이려면 키보드를 이용하세요", "버블이 있으면 8초간 무적상태가 돼요" };
    void GameStart()
    {
        // start
		if (_gameTime <= 0)
		{
            CancelInvoke("GameStart");
            _timeText.text = "";
            _descriptionText.text = "";
            bestCount = int.Parse(PlayerPrefs.GetString("BEST_COUNT", "0"));
            _bestText.text = bestCount.ToString();
            _carrotText.text = carrot.ToString();

            // 스플래스 UI 안보이게 만들기
            _rabitPrefab.SetActive(true);
            for (int i = _gameElement.Length-1; i >= 0; i--)
            {
                _gameElement[i].enabled = true;
            }

        }
        // splash
		else
		{
            _timeText.text = (_gameTime--).ToString();
            _descriptionText.text = gameDescription[pos];
            pos++;

            // 게임 UI 안보이게 만들기
            for (int i = _gameElement.Length-1; i >= 0; i--)
            {
                _gameElement[i].enabled = false;
            }
        }
    }

    public void GameEnd()
    {
        SceneManager.LoadScene("Game");
        BestScoreSave();
    }

    public void GetCarrot() 
    {
        _carrotText.text = (++carrot).ToString();
        if (carrot > bestCount)
        {
            _bestText.text = (++bestCount).ToString();
        }
    }

    void BestScoreSave()
    {
        int count = int.Parse(PlayerPrefs.GetString("BEST_COUNT", "0"));
        if (bestCount > count)
        {
            PlayerPrefs.SetString("BEST_COUNT", bestCount.ToString());
            PlayerPrefs.Save();
        }
    }


	public void CreateBubble()
	{
		if (_bubble.activeSelf) return;
        _bubble.SetActive(true);
        Invoke("DestroyBubble", 8f);
        // _bubble.GetComponent<Animator>().Play("Disapper", 0);
    }

	public void DestroyBubble()
	{
        _bubble.GetComponent<Animator>().PlayInFixedTime(0);
        _bubble.SetActive(false);
    }



}
