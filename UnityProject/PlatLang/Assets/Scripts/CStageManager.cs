using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 게임화면에서 스테이지를 관리하는 클래스
public class CStageManager : MonoBehaviour
{
    // public static CStageManager instance = null;
    public string _passMain;

    public enum LANGTYPE
    {
        ENG, JP, CH
    }
    public LANGTYPE _lang;

    string _wordTxt;
    string _speakTxt;

    int _stageNum;
    GameObject _panel;

    public Text _wordText;
    public GameObject _wordPanel;
    public GameObject _studyPanel;

    public List<Button> _noOverlaps;

    public Button[] _studyWord;

    void Awake()
    {
        // 바로 메인으로 시작하기 위한 임시 함수
        int passMain = PlayerPrefs.GetInt("passMain", 0);
        if (passMain == 0)
        {
            SceneManager.LoadScene("Main");
            PlayerPrefs.SetInt("passMain", 1);
        }
    }

    void Init(int langMode)
    {
        // 단어 학습 전으로 돌리기
        foreach (Button item in _studyWord)
        {
            item.image.sprite = item.spriteState.pressedSprite;
        }

        // 언어 설정
        switch (langMode)
        {
            case 0:
                _lang = LANGTYPE.ENG;
                _wordTxt = _speakTxt = "Monkey";
                EasyTTSUtil.Initialize(EasyTTSUtil.UnitedStates);
                break;
            case 1:
                _lang = LANGTYPE.CH;
                _wordTxt = "猴子[hóuzi]";
                _speakTxt = _wordTxt.Split('[')[0];
                EasyTTSUtil.Initialize(EasyTTSUtil.China);
                break;
            case 2:
                _lang = LANGTYPE.JP;
                _wordTxt = "さる[猿]";
                _speakTxt = _wordTxt.Split('[')[0];
                EasyTTSUtil.Initialize(EasyTTSUtil.Japan);
                break;
            case 3:
            case 4:
                break;
        }

        Button[] studyButton = _studyPanel.GetComponentsInChildren<Button>();
        Button[] speakButton = _wordPanel.GetComponentsInChildren<Button>();

        foreach (Button item in studyButton)
        {
            _noOverlaps.Add(item);
        }
        foreach (Button item in speakButton)
        {
            _noOverlaps.Add(item);
        }
    }

    public void ShowWord(int langNum)
    {
        Init(langNum);
        _wordPanel.SetActive(true);
        _wordText.text = _wordTxt;
    }

    public void HideWord()
    {
        _wordPanel.SetActive(false);
        EasyTTSUtil.StopSpeech();
    }

    public void SpeakWord()
    {
        EasyTTSUtil.SpeechFlush(_speakTxt);
        StartCoroutine("PlayTTSCoroutine");
        Debug.Log(_speakTxt + " TTS");
    }


    IEnumerator PlayTTSCoroutine()
    {
        foreach (Button item in _noOverlaps)
        {
            item.enabled = false;
        }

        yield return new WaitForSeconds(3f);

        foreach (Button item in _noOverlaps)
        {
            item.enabled = true;
        }
    }

    protected void StageSpecialAction()
    {

    }

    void OnApplicationQuit()
    {
        Debug.Log("스테이지 매니저 종료");
        EasyTTSUtil.Stop();
        PlayerPrefs.SetInt("passMain", 0);
    }

}
