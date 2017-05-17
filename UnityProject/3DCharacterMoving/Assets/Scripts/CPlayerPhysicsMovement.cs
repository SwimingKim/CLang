using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerPhysicsMovement : MonoBehaviour {

	// 전진 속도
	public float _forwardSpeed = 7.0f;
    // 후진 속도
    public float _backwardSpeed = 2.0f;
    // 회전 속도
    public float _rotateSpeed = 25f;

    private Animator _animator;
    private Rigidbody _rigidbody;

    // 애니메이션 속도
    public float _animSpeed = 1.2f;

    // 이동 벡터
    private Vector3 _velocity;

	void Awake()
	{
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
        _animator.speed = _animSpeed;
    }

	void FixedUpdate()
	{
		// 키입력 터리
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 애니메이션 속도 설정
        _animator.SetFloat("Speed", v);

        _velocity = transform.forward * v;

		// 이동 방향 벡터 설정
		if (v > 0.1)
		{
            _velocity *= _forwardSpeed;
        }
		else if (v < -0.1)
		{
            _velocity *= _backwardSpeed;
        }

        // 이동 처리
        _rigidbody.MovePosition(transform.position + _velocity * Time.deltaTime);


        // 회전 처리
        Quaternion deltaRotation = Quaternion.Euler(new Vector3(0f, h * _rotateSpeed, 0f) * Time.deltaTime);
        _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);

    }

}
