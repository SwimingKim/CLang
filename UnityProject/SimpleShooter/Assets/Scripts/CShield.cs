using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 방어막
public class CShield : MonoBehaviour {

	// 충돌 이벤트
	void OnTriggerEnter2D(Collider2D other)
	{
        // 카메라를 제외한 충돌한 모든 오브젝트를 파괴함
		if (other.tag == "Meteor")
		{
			Destroy(other.gameObject);
		}
	}

	
}
