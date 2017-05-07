using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHpUpItem : MonoBehaviour {

    CPlayerShipHealth _playerHealth; // 플레이어 입력 발포 참조

    void Start()
	{
		// GameObject.Find("이름") : 게임 오브젝트를 이름으로 검색
		// GameObject.FindGameObjectWithTag("태그명") : 게임 오브젝트를 태그로 검색
        _playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<CPlayerShipHealth>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PlayerShip")
        {
            // 플레이어의 체력을 50 증가 시킴
            _playerHealth.HpUp(50);

            // 아이템을 파괴함
            Destroy(gameObject);
        }
    }

}
