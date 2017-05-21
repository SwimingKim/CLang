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

    string wordText;
    string speakText;

    int stageNum;
    GameObject panel;

    // public GameObject CanvasType;
    public GameObject WordPanel;
    public GameObject StudyPanel;
    Text WordText;

    public List<Button> NoOverlaps;


    void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);

        // if (CanvasType != null)
        // {
        //     Instantiate(CanvasType);
        //     Debug.Log("시작");
        // }
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

    void Init(int langNum)
    {
        switch (langNum)
        {
            case 0:
                lang = LANGTYPE.ENG;
                wordText = speakText = "Monkey";
                EasyTTSUtil.Initialize(EasyTTSUtil.UnitedStates);
                break;
            case 1:
                lang = LANGTYPE.CH;
                wordText = "猴子[hóuzi]";
                speakText = wordText.Split('[')[0];
                EasyTTSUtil.Initialize(EasyTTSUtil.China);
                break;
            case 2:
                lang = LANGTYPE.JP;
                wordText = "さる[猿]";
                speakText = wordText.Split('[')[0];
                EasyTTSUtil.Initialize(EasyTTSUtil.Japan);
                break;
        }
    }

    public void ShowWord(int langNum)
    {
        Init(langNum);
        WordPanel.SetActive(true);
        WordText.text = wordText;
    }

    public void HideWord()
    {
        WordPanel.SetActive(false);
        EasyTTSUtil.StopSpeech();
    }

    public void SpeakWord()
    {
        EasyTTSUtil.SpeechFlush(speakText);
        StartCoroutine("PlayTTSCoroutine");
        Debug.Log(speakText + " TTS");
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
