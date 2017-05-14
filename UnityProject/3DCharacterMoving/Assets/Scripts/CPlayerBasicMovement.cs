using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerBasicMovement : MonoBehaviour {

    public float _forwardSpeed; // 전진 속도
    public float _backwardSpeed; // 후진 속도
    public float _rotateSpeed; // 회전 속도

    Animator _animator;
    public float _animSpeed; // 애니메이션 속도

	void Awake()
	{
        _animator = GetComponent<Animator>();
        _animator.speed = _animSpeed;
    }

	void Update()
	{
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 애니메이션 설정
        _animator.SetFloat("Speed", v);

        // 이동 방향 설정
        Vector3 velocity = new Vector3(0f, 0f, v);
        // 로컬 회전축을 월드 회전축에 맞춤
        velocity = transform.TransformDirection(velocity);


		if (v > 0.1f)
		{
            // 전진 속도 설정
            velocity *= _forwardSpeed;
        }
		else if (v < -0.1f)
		{
            // 후진 속도 설정
            velocity *= _backwardSpeed;
        }

        // 이동
        transform.position += velocity * Time.deltaTime;
        // transform.Translate(velocity * Time.deltaTime);

        // 회전
        transform.Rotate(new Vector3(0f, h * _rotateSpeed, 0) * Time.deltaTime);
    }

}
