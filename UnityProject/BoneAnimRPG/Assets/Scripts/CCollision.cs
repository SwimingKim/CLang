using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CCollision을 컴포넌트로 추가하면 어떤 일이? 뜨아
public abstract class CCollision : MonoBehaviour {

    /*
	public virtual void Hit(bool isWeapon)
	{
		// 나는 왜 존재하여야 하는가?
	}
	*/

    // 구현이 필요없는 메소드는 추상화해야 함
    public abstract void Hit(bool isWeapon);

}
