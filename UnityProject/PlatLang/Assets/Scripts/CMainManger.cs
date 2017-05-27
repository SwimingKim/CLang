using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CMainManger : MonoBehaviour
{
    public static CMainManger instance;

    public CMainCameraMovement cameraMovement;

    public Transform[] _canvas;
    public GameObject[] _stagePanel;
    public GameObject[] _langPanel;
    public Image[] characterImage;

    public int canvasNum = 0;
    public int stageNum = 0;

    void Awake()
    {
        instance = this;
    }

    public void CameraMove()
    {
        cameraMovement.canMove = true;
        canvasNum = (canvasNum >= 2) ? 0 : ++canvasNum;

        StageStateReset();
        LangStateReset();
        _langPanel[0].GetComponent<CLangCanvasPanelState>().ChangePressed();

        // CSoundManager.instance._effectSource.Play();
    }

    public void StageStateReset()
    {
        for (int i = 0; i < _stagePanel.Length; i++)
        {
            _stagePanel[i].GetComponent<CCanvasPanelState>().ChangeNormal();
        }
    }

    public void LangStateReset()
    {
        for (int i = 0; i < _langPanel.Length; i++)
        {
            _langPanel[i].GetComponent<CCanvasPanelState>().ChangeNormal();
        }
    }

    public void StartGame()
    {
        CGameManager.instance.StartStage();
    }

}

