using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSpaceCollision : MonoBehaviour {

	// 우주의 영역을 빠져간 충돌 오브젝트가 있다면
	void OnTriggerExit2D(Collider2D other)
	{
        Destroy(other.gameObject); // 파괴하라
    }

}
