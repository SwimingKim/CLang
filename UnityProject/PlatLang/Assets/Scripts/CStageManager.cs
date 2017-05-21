using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 게임화면에서 스테이지를 관리하는 클래스
public class CStageManager : MonoBehaviour
{
    public static CStageManager instance = null;

    public enum LANGTYPE
    {
        ENG, JP, CH
    }
    public LANGTYPE lang;

    string WordTxt;
    string SpeakTxt;

    int stageNum;
    GameObject panel;

    public Text WordText;
    public GameObject WordPanel;
    public GameObject StudyPanel;

    public List<Button> NoOverlaps;


    void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
    }

    void Start()
    {
        Debug.Log("추가");
        Button[] wordBtns = StudyPanel.GetComponentsInChildren<Button>();
        foreach (Button item in wordBtns)
        {
            NoOverlaps.Add(item);
        }

        Button[] speakBtns = WordPanel.GetComponentsInChildren<Button>();
        foreach (Button item in speakBtns)
        {
            NoOverlaps.Add(item);
        }
    }

    void Init(int langMode)
    {
        switch (langMode)
        {
            case 0:
                lang = LANGTYPE.ENG;
                WordTxt = SpeakTxt = "Monkey";
                EasyTTSUtil.Initialize(EasyTTSUtil.UnitedStates);
                break;
            case 1:
                lang = LANGTYPE.CH;
                WordTxt = "猴子[hóuzi]";
                SpeakTxt = WordTxt.Split('[')[0];
                EasyTTSUtil.Initialize(EasyTTSUtil.China);
                break;
            case 2: case 3: case 4:
                lang = LANGTYPE.JP;
                WordTxt = "さる[猿]";
                SpeakTxt = WordTxt.Split('[')[0];
                EasyTTSUtil.Initialize(EasyTTSUtil.Japan);
                break;
        }
    }

    public void ShowWord(int langNum)
    {
        Init(langNum);
        WordPanel.SetActive(true);
        WordText.text = WordTxt;
    }

    public void HideWord()
    {
        WordPanel.SetActive(false);
        EasyTTSUtil.StopSpeech();
    }

    public void SpeakWord()
    {
        EasyTTSUtil.SpeechFlush(SpeakTxt);
        StartCoroutine("PlayTTSCoroutine");
        Debug.Log(SpeakTxt + " TTS");
    }

    void OnApplicationQuit()
    {
        EasyTTSUtil.Stop();
    }

    IEnumerator PlayTTSCoroutine()
    {
        foreach (Button item in NoOverlaps)
        {
            item.enabled = false;
        }

        yield return new WaitForSeconds(3f);

        foreach (Button item in NoOverlaps)
        {
            item.enabled = true;
        }
    }


}
