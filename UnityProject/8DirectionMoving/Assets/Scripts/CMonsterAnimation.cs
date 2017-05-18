using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonsterAnimation : MonoBehaviour {

	Animator _animator;

	CMonsterFSM _fsm;

	void Awake()
	{
		_animator = GetComponent<Animator>();
		_fsm = GetComponent<CMonsterFSM>();
	}

	// 거미 애니메이션 재생
	public void PlayAnimation(CMonsterFSM.STATE state)
	{
		switch (state)
		{
			case CMonsterFSM.STATE.IDLE : // 대기 상태 애니메이션 처리
				_animator.SetBool("Walk", false);
				_animator.SetBool("Attack", false);
				break;
			case CMonsterFSM.STATE.TRACE : // 추적 상태 애니메이션 처리
				_animator.SetBool("Walk", true);
				_animator.SetBool("Attack", false);
				break;
			case CMonsterFSM.STATE.ATTACK : // 공격 상태 애니메이션 처리
				_animator.SetBool("Walk", false);
				_animator.SetBool("Attack", true);
				break;
			case CMonsterFSM.STATE.DIE : // 사망 상태 애니메이션 처리
				_animator.SetTrigger("Death");
				break;
		}
	}

	
}
