using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CGameOverManager : MonoBehaviour {

	public void OnRestartButtonClick()
	{
        SceneManager.LoadScene("Game");
    }

}
