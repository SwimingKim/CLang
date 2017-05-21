using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CGameManager : MonoBehaviour
{
    public static CGameManager instance = null;
    public bool passMain = false;
    public int sceneNum;

    void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void LoadScene(int sceneNum)
    {
        this.sceneNum = sceneNum;
        switch (sceneNum)
        {
            case 0: // Main
                SceneManager.LoadScene("Main");
                break;
            case 1: // Attack
                SceneManager.LoadScene("Attack");
                CSoundManager.instance.PlayEffect();
                break;
            case 2: // Blink
                SceneManager.LoadScene("Blink");
                CSoundManager.instance.PlayEffect();
                break;
            case 3: // Bomb
                SceneManager.LoadScene("Bomb");
                CSoundManager.instance.PlayEffect();
                break;
            case 4: // Smash
                SceneManager.LoadScene("Smash");
                CSoundManager.instance.PlayEffect();
                break;
        }

    }

}
