using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 비행기 체력
public class CShipHealth : MonoBehaviour {

    public int _hp; // 체력 수치

	// 체력 감소
	public virtual int HpDown(float damage)
	{
        _hp -= (int)damage; // 체력을 감소함

        return _hp;
    }

	// 적기를 사망처리함
	public virtual void DoDestroy()
	{
        Destroy(gameObject);
    }

    // 수동 파괴
    public void ManualDestroy()
    {
        // GetComponent<CShipDamage>().ShowHitEffect(transform.position);

        // 데미지 컴포넌트를 참조하여
        CShipDamage damage = GetComponent<CShipDamage>();
        damage.ShowHitEffect(transform.position); // 이펙트 실행을 요청함


        DoDestroy(); // 오브젝트를 파괴함
    }


}
