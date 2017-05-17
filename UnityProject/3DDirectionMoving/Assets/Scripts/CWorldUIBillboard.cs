using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CWorldUIBillboard : MonoBehaviour
{

    private void LateUpdate()
    {
        // Quaternion.LookRotation(같은방향을보는오브젝트의 시선(forward)벡터)
        transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward);
    }

}