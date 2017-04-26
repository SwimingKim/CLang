using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAllKillItem : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "PlayerShip")
		{
            // 모든 적기를 찾아서 수동 파괴를 요청함

			// GameObject.FindGameObjectsWithTag("태그명") : 태그명으로 지정된 모든 게임 오브젝트를 참조힘
			GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

			for (int i = 0; i < enemies.Length; i++)
			{
				// 적기들의 체력 컴포넌트를 참조함
                CShipHealth health = enemies[i].GetComponent<CShipHealth>();
                health.ManualDestroy(); // 수동 파괴시킴

            }

            Destroy(gameObject); // 아이템 제거

        }	
	}
}
