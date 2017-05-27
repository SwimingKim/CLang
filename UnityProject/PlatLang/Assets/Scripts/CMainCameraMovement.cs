using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMainCameraMovement : MonoBehaviour
{
    Transform _target; // 추적 타겟
    public float _smoothValue; // 이동 보간(부드러움)
    public Vector3 _offset; // 추적 간격
    CMainManger manager;

    public bool canMove = false;

    void Awake()
    {
        manager = CMainManger.instance;
    }

    void Start()
    {
        transform.position = manager._canvas[manager.canvasNum].position + _offset;
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            // CameraMove(CMainManger.instance.canvasNum);
            // 업데이트시 간격 위치 갱신
            Vector3 targetCampPos = manager._canvas[manager.canvasNum].position + _offset;
            // 부드럽게 위치 이동 설정
            transform.position = Vector3.Lerp(transform.position, targetCampPos, _smoothValue + Time.deltaTime);

            // 회전
            // transform.rotation = Quaternion.RotateTowards(transform.rotation, toCanvas.rotation, 10f);
            // 이동
            // Vector3 fromVector, toVector;
            // transform.position = Vector3.Lerp(transform.position, _menuCanvas.position, Time.fixedDeltaTime + 10f);
        }
    }

}
