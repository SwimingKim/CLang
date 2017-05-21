using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CLoader : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject soundManager;
    public GameObject[] stageManager;

    void Awake()
    {
		// 스테이지에서 불러오기
        if (CStageManager.instance == null && SceneManager.GetActiveScene().name != "Main")
        {
			if (CGameManager.instance == null)
			{
				SceneManager.LoadScene("Main");	
			}
			else
			{
				Debug.Log(CGameManager.instance.sceneNum-1);
	            Instantiate(stageManager[CGameManager.instance.sceneNum-1]);
			}
        }
		else // 메인에서 불러오기
        {
            if (CGameManager.instance == null && gameManager != null) Instantiate(gameManager);
            if (CSoundManager.instance == null && soundManager != null) Instantiate(soundManager);
			CGameManager.instance.passMain = true;
        }

    }

}
