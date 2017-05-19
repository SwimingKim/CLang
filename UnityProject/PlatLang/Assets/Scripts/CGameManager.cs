using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CGameManager : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    public void LoadAttackStage()
    {
        SceneManager.LoadScene("Attack");
    }

    public void LoadSmashStage()
    {
        SceneManager.LoadScene("Smash");
    }

    public void LoadBlinkStage()
    {
        SceneManager.LoadScene("Blink");
    }

    public void LoadBombStage()
    {
        SceneManager.LoadScene("Bomb");
    }

    public void LoadMainStage()
    {
        SceneManager.LoadScene("Main");
    }
}
