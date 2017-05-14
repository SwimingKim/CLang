using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTankTargetLookAt : MonoBehaviour
{

    public Transform _lookTarget;

    void Start()
    {

    }

    void Update()
    {
        // Transform.LookAt(타겟) : 타겟을 바라봄
        transform.LookAt(_lookTarget);

    }

}
