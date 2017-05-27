using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStagePanelState : MonoBehaviour
{
    public bool isSelect = false;
    public GameObject _infoPanel;

    public void StateNormal()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
        _infoPanel.SetActive(false);
        isSelect = false;
    }

    public void StatePressed()
    {
        gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        _infoPanel.SetActive(true);
        isSelect = true;
    }

}
