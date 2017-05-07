using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShotDamage : MonoBehaviour {

	void Update()
	{
        // 화면을 벗어나면 삭제하기
        Vector2 pos = transform.position;
		if (pos.x >= 9.6f) // Y_LIMIT_POS
		{
            Destroy(gameObject);
        }
    }

	void OnTriggerEnter2D(Collider2D other)
	{
        // 적을 없애기
		if (other.gameObject.tag == "Enemy")
		{
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }


}
