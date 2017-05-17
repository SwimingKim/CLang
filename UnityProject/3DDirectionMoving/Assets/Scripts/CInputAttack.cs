using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 입력에 의한 공격 처리
public class CInputAttack : MonoBehaviour
{
	// 피격 포인트
	public Transform _attackPoint;
	// 데미지 범위
	public float _damageRange;

	private CCharacterAnimation _anim;

	private void Awake()
	{
		_anim = GetComponent<CCharacterAnimation>();
	}


	void Update () {

		if (_anim.IsAttackAnimationPlaying()) return;

		// Z키를 누르면
		if (Input.GetKeyDown(KeyCode.Z))
		{
			// 공격 애니메이션을 수행
			_anim.PlayAnimation(CCharacterAnimation.ANIM_TYPE.ATTACK);
		}
		
	}

	void Attack()
	{
		// 공격포인트(AttackPoin)를 기준으로 0.7 반경 안에서 Spider 충돌레이어를 가진 오브젝트들을 검출함
		Collider[] hitColliders = Physics.OverlapSphere(_attackPoint.position, _damageRange,
			1 << LayerMask.NameToLayer("Monster"));

		// 헛빵
		if (hitColliders.Length <= 0) return;

		hitColliders[0].SendMessage("Damage");
	}

}
