using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CCanvasPanelClick : MonoBehaviour
{
    GameObject mainCamera;

    CCanvasPanelState state;
	Button btn;

	public int index;

    void Awake()
    {
        state = gameObject.GetComponent<CCanvasPanelState>();
		btn = gameObject.GetComponent<Button>();
    }

	protected virtual void Start()
	{
		btn.onClick.AddListener(()=>ChangeCanvas());
	}

    public virtual void ChangeCanvas()
    {
        Debug.Log(gameObject.name);
        if (!state.isSelect)
        {
            CMainManger.instance.StageStateReset();
            state.ChangePressed();
			CSoundManager.instance._effectSource.Play();
        }
        else
        {
			switch (CMainManger.instance.canvasNum)
			{
				// 스테이지 선택
				case 1:
					CGameManager.instance.stage = index;
					Debug.Log("스테이지 = " + index);
					CMainManger.instance.CameraMove();
					break;
				// 언어 선택
				case 2:
					CGameManager.instance.lang = index;
					Debug.Log("언어 = " + index);
					CMainManger.instance.StartGame();
					break;
				default:
					break;
			}
        }
    }

}
