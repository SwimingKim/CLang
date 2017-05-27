using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCanvasClick : MonoBehaviour
{
	GameObject mainCamera;

    public virtual void ChangeCanvas(int num)
    {
		CMainManger.instance.CameraMove(num);
        // cameraMove.ChangeCamera();
    }

}
