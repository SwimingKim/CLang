using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CGameManager : MonoBehaviour {

    public static int _bombState =  2;
    public float _endWaitTime;

	public Image ShieldBar;
    public Text ShieldText;

    public Image _goImage;
    public Image _overImage;

    void Start()
	{
        StartCoroutine("GameStart");
    }

	IEnumerator GameEnd()
	{
        // 점수 저장
        yield return new WaitForSeconds(_endWaitTime - 1);

        _overImage.enabled = true;
        yield return new WaitForSeconds(1f);

        Text scoreText = GameObject.Find("StarCountText").GetComponent<Text>();
        PlayerPrefs.SetString("SCORE", scoreText.text);
        PlayerPrefs.Save();
        SceneManager.LoadScene("End");
    }

    IEnumerator GameStart()
    {
        ShieldBar.enabled = false;
        ShieldText.enabled = false;

        yield return new WaitForSeconds(1.5f);
        _goImage.enabled = false;
    }

}
