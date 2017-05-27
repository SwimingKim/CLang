using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CCanvasPanelState : MonoBehaviour
{
    public bool isSelect = false;

    public abstract void ChangeNormal();
    public abstract void ChangePressed();

}
