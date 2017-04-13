using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipDamage : MonoBehaviour {

	// OnTriggerEnter2d()
	// - IsTrigger 체크가 되어 있는 오브젝트가 충돌했을 경우 호출되는 이벤트 메소드
	// collision 매개변수는 충돌한 상대 오브젝트의 콜라이더를 의미함
	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(other.name + "오브젝트와 충돌함");
		// Destroy(게임오브젝트이름);
		// Destroy(gameObject); // 비행기가 사라짐
		Destroy(other.gameObject);
	}

}
