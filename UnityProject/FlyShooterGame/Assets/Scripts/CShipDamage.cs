using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipDamage : MonoBehaviour {

    // 파격 효과 프리팹
    public GameObject _damageEffectPrefab;

    public Animator _animator; // 에니메이터 컴포넌트 참조

	public CShipHealth _shipHealth; // 비행기 체력


	// 충돌 Enter 이벤트
	protected virtual void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Laser")
		{
            Hit(other);
        }
    }

	public void Hit(Collider2D collision)
	{
        // 레이저를 제거함
        Destroy(collision.gameObject);

        // 피격 이펙트를 보여줌
        ShowHitEffect(collision.transform.position);

        // 체력을 감소시킴
        int hp = _shipHealth.HpDown(30);

        // 체력이 0이하로 되면
        if (hp <= 0)
        {
            // 비행기 오브젝트를 파괴함
            _shipHealth.DoDestroy();
        }
	}

    // 피격 이펙트를 보여줌
    public void ShowHitEffect(Vector2 pos)
    {
        // 데미지 이펙트 프리팹 설정이 안되어 있다면 이펙트 효과를 생성하지 않음
        if (_damageEffectPrefab != null)
        {
            // 피격 위치에 피격 효과 오브젝트를 생성함
            GameObject effect = Instantiate(_damageEffectPrefab, pos, Quaternion.identity);
            // Destroy(파괴오브젝트참조변수, 파괴지연시간);
            Destroy(effect, 0.3f);
        }

        // 0번 레이터(Base Layer)에 Damage란 이름을 가진 애니메이션을 실행함
        _animator.Play("Damage", 0);

    }


}
