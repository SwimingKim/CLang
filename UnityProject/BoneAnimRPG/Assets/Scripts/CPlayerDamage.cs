using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerDamage : MonoBehaviour {

    public CPlayerHealth _health; // 플레이어 체력 참조

    Animator _animator; // 애니메이터

    void Start () {
        _animator = GetComponent<Animator>();
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag.ToLower().Equals("zombie"))
		{
			// 이미 피격을 당해 피해를 입고 있는 상태라면 패쓰~
			if (_animator.GetCurrentAnimatorStateInfo(1).IsName("Damage")) return;

            _health.HpDown(); // 체력 감소

            Debug.Log("Damage");

            // 데미지 애니메이션을 수행함
            _animator.Play("Damage");
        }
	}
}
