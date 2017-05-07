using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMiniShipDestroy : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		// 적기 또는 레이저와 충돌하면
		if (other.tag == "Enemy" || other.tag == "Laser")
		{
            Destroy(gameObject); // 비행기를 파괴함
        }
	}

}
