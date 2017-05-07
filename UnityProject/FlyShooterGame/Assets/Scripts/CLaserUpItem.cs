using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLaserUpItem : MonoBehaviour {

    CInputShot _playerShot; // 플레이어 입력 발포 참조

	void Start()
	{
        // GameObject.Find("이름") : 게임 오브젝트를 이름으로 검색
        // GameObject.FindGameObjectWithTag("태그명") : 게임 오브젝트를 태그로 검색
        _playerShot = GameObject.FindGameObjectWithTag("Player").GetComponent<CInputShot>();
    }

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "PlayerShip")
		{
			// 플레이어의 발포 카운트를 증가시킴
            _playerShot.ShotCountUp();

            Destroy(gameObject);
        }	
	}

}
