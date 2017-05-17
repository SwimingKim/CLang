using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInputMovement : MonoBehaviour
{

	public float _speed; // 이동 속도
	public float _gravity; // 추가적인 중력 설정
	private Vector3 _moveDirection; // 이동 방향
	private CharacterController _cc; // 캐릭터 컨트롤러
	CCharacterAnimation _anim; // 캐릭터 애니메이션 제어

	private void Awake()
	{
		_cc = GetComponent<CharacterController>();
		_anim = GetComponent<CCharacterAnimation>();
	}

	void Update () {
		Move(); // 입력 이동 처리
	}

	// 입력 이동 처리
	void Move()
	{
		// 공격 중이면 이동하지 말아라
		if (_anim.IsAttackAnimationPlaying()) return;

		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		// 입력 방향 벡터 설정
		_moveDirection = new Vector3(h, 0f, v);

		// 키 입력이 없다면
		if (_moveDirection == Vector3.zero)
		{
			// 대기 애니메이션 재생
			_anim.PlayAnimation(CCharacterAnimation.ANIM_TYPE.IDLE);
		}
		else // 키 입력이 있다면
		{
			// 이동 애니메이션 재생
			_anim.PlayAnimation(CCharacterAnimation.ANIM_TYPE.WALK);

			// 이동 처리

			// 시선 방향 설정
			transform.forward = _moveDirection.normalized;

			// 임시 속도 설정
			float speed = _speed;

			if (h != 0 && v != 0) // 동시 방향키를 눌렀다면
			{
				// 대각선 방향에 맞는 속도로 계산함
				float degree = Mathf.Cos(45f * Mathf.Deg2Rad);
				speed *= degree;
			}

			// 이동 속도 적용
			_moveDirection *= speed;

			// 중력 처리 적용
			_moveDirection.y -= _gravity;

			// 캐릭터 컨트롤러를 이용해서 이동을 수행
			_cc.Move(_moveDirection * Time.deltaTime);
		}
	}

}
