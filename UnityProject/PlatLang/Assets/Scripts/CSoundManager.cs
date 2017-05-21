using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CSoundManager : MonoBehaviour
{
    public static CSoundManager instance = null;

    public AudioSource mainSource;
    public AudioSource effectSource;

    public bool isPlayingBGM;

    void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        isPlayingBGM = PlayerPrefs.GetInt("BGM", 1) == 1 ? true  : false;
        Debug.Log("start = "+isPlayingBGM);
    }

    public void PlayEffect()
    {
        // effectSource.pitch = 0.9f;
        effectSource.Play();
    }

    public void PlayBGM()
    {
        isPlayingBGM = true;
        if (mainSource.time == 0)
        {
            mainSource.Play();
        }
        else
        {
            mainSource.UnPause();
        }
    }

    public void PauseBGM()
    {
        isPlayingBGM = false;
        mainSource.Pause();
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("BGM", isPlayingBGM ? 1 : 0);
    }

    void OnApplicationQuit()
    {
        mainSource.Stop();
    }

}
