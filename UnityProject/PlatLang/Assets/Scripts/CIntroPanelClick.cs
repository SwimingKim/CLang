using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CIntroPanelClick : CCanvasPanelClick {

	public override void ChangeCanvas()
	{
		CMainManger.instance.CameraMove();
	}

}
