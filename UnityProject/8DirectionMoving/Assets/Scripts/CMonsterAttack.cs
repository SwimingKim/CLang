using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonsterAttack : MonoBehaviour {

	// 공격 대상
	[HideInInspector]
	public GameObject _attackTarget;
	
	// 공격 위치
	public Transform _attackPoint;
	// 공격 범위
	public float _attackRange;
	// 공격 데미지
	public float _damage;

	void Start () {
		// 공격 대상 지정
		_attackTarget = GameObject.FindGameObjectWithTag("Player");
	}

	// 공격 대상과의 거리를 계산함
	public float GetAttackTargetDistance()
	{
		float dist = Vector3.Distance(
			_attackTarget.transform.position, transform.position
		);
		return dist;
	}
	
	// 공격을 수행함
	public void Attack()
	{
		
	}

}
