using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 적기 지연 발포
public class CEnemyDelayShot : CShot {

	// 격발 지연 타임
    public float _fireDelayTime;
	// 격발 위치
    int _shotPosNum = 0;

    public CDirectMovement _movement;

    void Start () {
        Invoke("StartShot", _shotDelayTime);
    }
	
	void StartShot()
	{
        Invoke("Shot", _fireDelayTime);
    }	

	// 지연 샷
	public override void Shot()
	{
        _movement.Stop(); // 발포 시 이동 정지

        // 발포 위치 번호에 레이저를 생성함
        Fire(_laserPrefab, _shotPos[_shotPosNum].position, _shotPos[_shotPosNum].rotation);
        _shotPosNum++; // 발포 위치 증가

		// 현재 발포가 마지막 발포 위치라면
		if (_shotPosNum >= _shotPos.Length)
		{
            _movement.Resume(); // 발포 종료 후 이동 재개

            // 샷을 종료함
            Invoke("StartShot", _shotDelayTime);
            _shotPosNum = 0;
            return;
        }

		// 다음 샷을 격발 지연시간뒤 발포함
        Invoke("Shot", _fireDelayTime);
    }

}
