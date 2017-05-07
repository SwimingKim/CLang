using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CEndManager : MonoBehaviour {

    public Text _bestScroeText; // 최고 점수 출력
	

    // Use this for initialization
    void Start () {

        string strBestCount = PlayerPrefs.GetString("BEST_COUNT", "0");
        _bestScroeText.text = strBestCount;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
