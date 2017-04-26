using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 입력 발포
public class CInputShot : CShot {

	float _timer; // 발포 간격 누적 시간

    private void Start () {
		
	}
	
	void Update () {
        _timer += Time.deltaTime; // 프레임 간격 타임을 누적함

        // Input.GetKeyDown(KeyCode.키이름)
        // - 키가 다운되면 1회 true를 리턴함
        // if (Input.GetKeyDown(KeyCode.LeftControl))
        if (Input.GetKeyDown(KeyCode.Space) && _timer >= _shotDelayTime)
		{
            // 생성(레이저 프리팹, 원점, 월드회전축)
            Shot();
            _timer = 0f; // 타임 초기화
        }
	}   
    
    // 발포 카운트 증가
    public void ShotCountUp()
    {
        // 현재 발포 카운트가 최대 카운트면 레이저 카운트를 증가시키지 않음
        if (_shotPosCount >= _shotPos.Length) return;

        // 발포 카운트를 2 증가함
        _shotPosCount += 2;

    }

}
