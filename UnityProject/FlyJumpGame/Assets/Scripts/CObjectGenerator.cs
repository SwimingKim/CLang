using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CObjectGenerator : MonoBehaviour {

    public Transform _createPos; // 생성 위치

    public GameObject _objectPrefab; // 생성 오브젝트 프리팹

    public float _topCreatePosy; // 위쪽 기둥 생성 위치
    public float _bottomCreatePosy; // 아래쪽 기둥 생성 위치

    public float _createStartTime; // 최초 생성 지연 시간 간격
    public float _createDelayTime; // 생성 지연 시간 간격

    // Use this for initialization
    void Start () {
        InvokeRepeating("CreateObject", _createStartTime, _createDelayTime);
    }

    void Update()
    {
        // 게임이 종료된 상태라면
        if (CGameManager.isGameStop)
        {
            // Invoke를 취소함
            CancelInvoke("CreateObject");
        }
        
    }
	
	void CreateObject()
	{
        // 게임이 종료된 상태면 기둥을 생성하지 않음
        // if (CGameManager.isGameStop) return;

        // 랜덤하게 높이를 구함
        float randY = Random.Range(_topCreatePosy, _bottomCreatePosy);

        // 생성 위치에 랜덤하게 y값을 적용함
        Vector2 createPos = new Vector2(_createPos.position.x, _createPos.position.y + randY);

        // 오브젝트 생성
        Instantiate(_objectPrefab, createPos, Quaternion.identity);
    }
	
}
