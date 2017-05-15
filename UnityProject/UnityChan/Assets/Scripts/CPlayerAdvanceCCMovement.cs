using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerAdvanceCCMovement : MonoBehaviour {

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

    // 점프 속도
    public float _jumpSpeed;

    // 중력 크기
    public float _gravity;

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

    // 이동
    public void Move()
    {
		// 바닥에 있는지를 체크함
		if (_cc.isGrounded)
		{
            // 회전 입력을 받음
            float h = Input.GetAxis("Horizontal");
            // 방향에 따른 애니메이션을 재생함
            _animator.SetFloat("Direction", h);
            // 캐릭터를 회전함
            transform.Rotate(0, h * rotateSpeed, 0);

            // 회전에 따른 캐릭터의 월드축 이동 방향을 구함
            _moveDirection = transform.TransformDirection(Vector3.forward);

            // 이동 입력을 받음
            float v = Input.GetAxis("Vertical");
            // 이동 속도에 따른 애니메이션을 재생함
            _animator.SetFloat("Speed", v);

            // 전 후방에 따른 속도 처리를 수행함
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
            _moveDirection *= _curSpeed;

			// 현재 점프 애니메이션을 수행하고 있지 않고 점프키를 눌렀다면
			if (Input.GetButton("Jump") && !_animator.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
			{
                // 점프크기를 설정함
                _moveDirection.y = _jumpSpeed;
                // 점프 애니메이션을 재생함
                _animator.SetBool("Jump", true);
            }
			// 현재 착지를 했지만 점프 애니메이션을 수행 중이라면
			else if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
			{
                _curSpeed = 0; // 이동 금지
                _moveDirection *= _curSpeed;
                _animator.SetBool("Jump", false); // 점프 끝
            }

            // 중력 처리를 수행함
            _moveDirection.y -= _gravity * Time.deltaTime;

            // 캐릭터 이동을 수행함
            _cc.Move(_moveDirection * Time.deltaTime);

        }
    }


}
