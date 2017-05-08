using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonsterDamage : MonoBehaviour {

    public Transform _damageEffectPos;
    public GameObject _damageEffectPrefab;
    protected CCharacterState _monsterState;
    Animator _animator;

    CDestroyer _destroyer;

	void Awake()
	{
        _monsterState = GetComponent<CCharacterState>();
        _animator = GetComponent<Animator>();
        _destroyer = GetComponent<CDestroyer>();
    }

	// 피격 처리
	public void Damage(float damage)
	{
		// 몬스터의 체력을 감소함
        _monsterState._hp -= damage;

		if (_monsterState._hp <= 0)
		{
            _destroyer.Destroy(); // 몬스터를 파괴하라
        }

        // 이펙트가 생성됩니다.
        // 피격 이펙트를 생성
        GameObject effect = Instantiate(_damageEffectPrefab, _damageEffectPos.position, Quaternion.identity);
        Destroy(effect, 0.25f);

        // 피격 애니메이션 재생
        _animator.Play("Damage", 1);
    }

}
