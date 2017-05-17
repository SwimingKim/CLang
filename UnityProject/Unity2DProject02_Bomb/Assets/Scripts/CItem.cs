using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이어와 아이템 충돌 시 해당 아이템 삭제
public class CItem : MonoBehaviour {

	protected virtual void OnTriggerEnter2D(Collider2D other)
	{
        Debug.Log(other.tag);
        if (other.tag == "Bomb")
		{
            Destroy(gameObject);
        }
	}

}
