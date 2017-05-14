using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTankRotationAround : MonoBehaviour
{

    public Transform _markTr; // 기준 변환점
    public float _rotSpeed; // 회전 속도

    void Start()
    {

    }

    void Update()
    {
        // Transform.RotationAround(기준위치, 회전축, 회전속도) : 둘레를 회전함
        transform.RotateAround(_markTr.position, Vector3.up, _rotSpeed * Time.deltaTime);

    }
}
