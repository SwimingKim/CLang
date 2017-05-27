using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStageCanvasClick : CCanvasClick {

	CStagePanelState state;

	void Awake()
	{
		state = gameObject.GetComponent<CStagePanelState>();
	}

	public override void ChangeCanvas(int num)
	{
		Debug.Log(gameObject.name);
		if (!state.isSelect)
		{
			CMainManger.instance.StageStageReset();
			state.StatePressed();
		}
		else
		{
			base.ChangeCanvas(num);
		}
	}

}
