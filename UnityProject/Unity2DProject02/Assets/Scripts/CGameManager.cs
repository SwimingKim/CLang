using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CGameManager : MonoBehaviour {

    public int _bombState =  0;

	public Image ShieldBar;
    public Text ShieldText;

    public float _endWaitTime;

    void Start()
	{
        ShieldBar.enabled = false;
        ShieldText.enabled = false;
	}

	IEnumerator GameEnd()
	{
        yield return new WaitForSeconds(_endWaitTime);

        SceneManager.LoadScene("End");
    }

}
