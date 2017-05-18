using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonsterFSM : MonoBehaviour {

	// 현재 상태
	public enum STATE {
		IDLE, // 대기
		TRACE, // 추적
		ATTACK, // 공격
		DIE // 사망
	}

	public STATE _state = STATE.IDLE;

	// 몬스터 이동
	CMonsterMovement _movement;

	// 몬스터 애니메이션
	CMonsterAnimation _anim;

	// 몬스터 공격
	CMonsterAttack _attack;

	// 상태 결정에 대한 속성들
	
	// 공격 가능 거리
	public float _attackDist;
	// 추적 가능 거리
	public float _traceDist;

	void Awake()
	{
		_movement = GetComponent<CMonsterMovement>();
		_anim = GetComponent<CMonsterAnimation>();
		_attack = GetComponent<CMonsterAttack>();
	}

	void Start()
	{
		StartCoroutine("MonsterCheckFSMCoroutine");
		StartCoroutine("MonsterDoActionCorountine");
	}

	// 현재 거미의 상태를 판단함
	IEnumerator MonsterCheckFSMCoroutine()
	{
		// 현재 거미가 사망한 게 아니라면 유한 상태를 유지함
		while (_state != STATE.DIE)
		{
			// 공격 대상(플레이어)이 존재하지 않으면
			if (_attack._attackTarget == null)
			{
				// 대기 상태로 변경함
				_state = CMonsterFSM.STATE.IDLE;

				yield return null;
				continue;
			}

			// 거미의 공격 대상과의 거리를 측정함
			float dist = _attack.GetAttackTargetDistance();
			// Debug.Log("거미와 플레이어와 거리 = " + dist);

			if (dist <= _attackDist)
			{
				_state = CMonsterFSM.STATE.ATTACK;
			}
			else if (dist <= _traceDist)
			{
				_state = CMonsterFSM.STATE.TRACE;
			}
			else
			{
				_state = CMonsterFSM.STATE.IDLE;
			}

			yield return null;
		}
	}

	// 현재 거미 상태에 대한 행동을 수행함
	IEnumerator MonsterDoActionCorountine()
	{
		while (_state != STATE.DIE)
		{
			// 상태에 따른 행동을 처리함
			switch (_state)
			{
				case CMonsterFSM.STATE.IDLE : // 현재 상태가 대기 상태면
					_movement.Stop(); // 이동 정지
					_anim.PlayAnimation(CMonsterFSM.STATE.IDLE); // 대기 애니메이션 처리
					break; 
				case CMonsterFSM.STATE.ATTACK : // 현재 상태가 공격 상태면
					// 공격 대상을 바라보고
					transform.LookAt(_attack._attackTarget.transform);
					// 이동을 멈추고
					_movement.Stop();
					// 공격 애니메이션을 수행함
					_anim.PlayAnimation(CMonsterFSM.STATE.ATTACK);
					break;
				case CMonsterFSM.STATE.TRACE : // 현재 상태가 추적 상태면
					// 이동 애니메이션을 수행
					_anim.PlayAnimation(CMonsterFSM.STATE.TRACE);
					// 추적 이동 시작
					_movement.Trace();
					break; 
			}

			yield return null;
		}

	}



}
