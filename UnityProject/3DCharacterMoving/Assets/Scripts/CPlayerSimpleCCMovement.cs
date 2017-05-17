using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerSimpleCCMovement : MonoBehaviour {

	// 전방 이동 속도
	public float _forwardSpeed;
    // 후방 이동 속도
    public float _backwardSpeed;
    // 회전 속도
    public float rotateSpeed;
    // 이동 방향
    protected Vector3 _moveDirection = Vector3.zero;
    // 현재 속도
    protected float _curSpeed;

    // 애니메이터
    protected Animator _animator;

    // 캐릭터 컨트롤러
    protected CharacterController _cc;

	void Awake()
	{
        _animator = GetComponent<Animator>();
        _animator.speed = 1.2f; // 애니메이션 속도 약간 빠르게
        _cc = GetComponent<CharacterController>();
    }

	void Update()
	{
        Move();
    }

    // 단순 이동
    public virtual void Move()
    {
        // 회전 입력에 따른 캐릭터 회전 처리
        float h = Input.GetAxis("Horizontal");
        // 방향에 따른 애니메이션의 변경
        _animator.SetFloat("Direction", h);
        transform.Rotate(0, h * rotateSpeed, 0);

        // 회전에 따른 캐릭터의 월드축 이동 방향을 구함(지역 -> 월드 방향)
        // _moveDirection = transform.TransformDiection(Vector3.forward);
        // 반대 (월드 -> 지역)
        // transform.InverseTransformDirection

        // 이동 입력에 따른 캐릭터 이동
        float v = Input.GetAxis("Vertical");
        // 속도에 따른 애니메이션 변경
        _animator.SetFloat("Speed", v);

        _moveDirection = transform.forward * v;

        // 전방 후방에 따른 속도 차이 설정
        float speed = 0;
		if (v > 0.1)
		{
            speed = _forwardSpeed;
        }
		else if (v < -0.1)
		{
            speed = _backwardSpeed;
        }

        // 현재 이동 속도를 구함
        _curSpeed = speed * v;

        // * 캐릭터 컨트롤러를 이용해서 단순 이동을 수행함
        _cc.SimpleMove(_moveDirection * _curSpeed);

    }




}
