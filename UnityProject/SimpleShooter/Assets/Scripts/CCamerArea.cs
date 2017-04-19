using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCamerArea : MonoBehaviour {

	// OnTriggerExit2D
	// - 충돌한 오브젝트가 충돌에서 벗어났을 때 호출되는 이벤트 메소드
	void OnTriggerExit2D(Collider2D other)
	{
		// 충돌에서 벗어난 모든 오브젝트를 파괴함
		if (other.tag == "Meteor")
		{
			Destroy(other.gameObject);
		}
	}
}
