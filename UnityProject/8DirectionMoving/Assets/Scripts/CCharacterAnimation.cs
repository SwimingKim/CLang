using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCharacterAnimation : MonoBehaviour
{
	// 애니메이션 타입
	public enum ANIM_TYPE
	{
		IDLE, WALK, ATTACK
	}

	private Animator _animator;

	public float _animSpeed;

	private void Awake()
	{
		_animator = GetComponent<Animator>();

		// 애니메이션 속도 설정
		_animator.speed = _animSpeed;
	}

	// 애니메이션을 재생함
	public void PlayAnimation(ANIM_TYPE animType)
	{
		switch (animType)
		{
			case ANIM_TYPE.IDLE:
				_animator.SetBool("Walk", false);
				break;
			case ANIM_TYPE.WALK:
				_animator.SetBool("Walk", true);
				break;
			case ANIM_TYPE.ATTACK:
				_animator.SetTrigger("Attack");
				break;
		}
	}

	// 공격 애니메이션이 재생중인지 체크
	public bool IsAttackAnimationPlaying()
	{
	/*	if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
		{
			return true; // 공격 애니메이션이 재생중임
		}

		return false; // 공격 애니메이션이 재생중이지 않음*/
		return _animator.GetCurrentAnimatorStateInfo(0).IsName("Attack");
	}

}
