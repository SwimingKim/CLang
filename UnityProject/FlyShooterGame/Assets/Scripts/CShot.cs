using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShot : MonoBehaviour {

	public GameObject _laserPrefab; // 레이저 프리팹
    public Transform[] _shotPos; // 발포 위치
    public float _shotDelayTime; // 발포간격시간

    protected int _shotPosCount = 1; // 발포 카운트

    protected virtual void Start()
    {
        // 발포 카운트 설정
        _shotPosCount = _shotPos.Length;
    }

    // 격발
    public void Fire(GameObject prefab, Vector2 pos, Quaternion qt)
    {
        Instantiate(prefab, pos, qt);
    }

    // 발포
	public virtual void Shot() // 레이저 생성
    {
        for (int i = 0; i < _shotPosCount; i++)
        {
            // 레이저를 발포 위치의 회전과 동일하게 회전해서 생성함
            // Instantiate(프리팹, 생성위치, 생성시회전(쿼터니언))
            Fire(_laserPrefab, _shotPos[i].position, _shotPos[i].rotation);
        }

    }

}
