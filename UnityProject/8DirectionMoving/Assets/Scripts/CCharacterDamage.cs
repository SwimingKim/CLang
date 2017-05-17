using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 캐릭터 피격 처리
public class CCharacterDamage : MonoBehaviour
{
	public Image _hpProgress; // 체력 게이지

	// 파티클 시스템
	public ParticleSystem _pcSystem;

	private Animator _animator;

	public bool _isDeath = false; // 사망 여부

	private void Awake()
	{
		_animator = GetComponent<Animator>();
	}

	// 피격 처리
	public void Damage()
	{
		if (_isDeath) return; // 이미 사망상태면 패쓰

		// 만약에 피격 이펙트가 실행중이 아니면
		if (!_pcSystem.isPlaying)
		{
			// 피격 이펙트를 실행해라 (파티클 재생)
			_pcSystem.Play();
		}

		// 30%로 체력 게이지를 감소시킴
		_hpProgress.fillAmount -= 0.3f;

		// 체력을 int 속성으로 변경함
		int hp = (int) (_hpProgress.fillAmount * 100f);
		if (hp <= 0)
		{
			// 사망 애니메이션을 재생
			_animator.SetTrigger("Death");
			_isDeath = true; // 사망 상태 설정
			return;
		}
	}


}
