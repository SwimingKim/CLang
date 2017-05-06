using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CEndManager : MonoBehaviour {

    public Text _scoreText;

    // Use this for initialization
    void Start () {
        _scoreText.text = PlayerPrefs.GetString("SCORE", "0");
    }
}
