using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMainManger : MonoBehaviour
{
    public static CMainManger instance;

	public CMainCameraMovement cameraMovement;

    public Transform[] _canvas;
    public GameObject[] _stagePanel;

    public int canvasNum = 0;
	public int stageNum = 0;

    void Awake()
    {
        instance = this;
    }

    public void CameraMove(int num)
    {
        Debug.Log(num);

        cameraMovement.canMove = true;
        canvasNum = (canvasNum >= 2) ? 0 : ++canvasNum;

        StageStageReset();
    }

    public void StageStageReset()
    {
        for (int i = 0; i < _stagePanel.Length; i++)
        {
            _stagePanel[i].GetComponent<CStagePanelState>().StateNormal();
        }
    }


}
