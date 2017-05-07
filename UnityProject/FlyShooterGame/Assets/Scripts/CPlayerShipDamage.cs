using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerShipDamage : CShipDamage {

	// 충돌 Enter 이벤트
	protected override void OnTriggerEnter2D(Collider2D other)
	{
		base.OnTriggerEnter2D(other);
		if (other.tag == "Enemy")
		{
			Hit(other);
		}
	}


}
