using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStageCanvasPanelState : CCanvasPanelState
{
    public GameObject _infoPanel;

    public override void ChangeNormal()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
        _infoPanel.SetActive(false);
        isSelect = false;
    }

    public override void ChangePressed()
    {
        gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        _infoPanel.SetActive(true);
        isSelect = true;
    }
}
