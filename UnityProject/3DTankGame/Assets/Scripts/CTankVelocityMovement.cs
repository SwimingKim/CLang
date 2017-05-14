using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTankVelocityMovement : MonoBehaviour {

    public float _moveSpeed; // 이동 속도
    public float _rotateSpeed; // 회전 속도

    Rigidbody _rigidbody;

    float h, v;

    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
    }

	void Update()
	{
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

	void FixedUpdate()
	{
        // // 월드 축에 맞춰서 방향축을 맞춰 줌
        // Vector3 moveDirection = transform.TransformDirection(new Vector3(0f, 0f, v));
        // // 이동
        // _rigidbody.velocity = moveDirection.normalized * _moveSpeed;
        _rigidbody.velocity = transform.forward * v * _moveSpeed;

        // 회전
        _rigidbody.angularVelocity = new Vector3(0f, h * _rotateSpeed / 360 * (Mathf.PI * 2), 0f);

    }
	
}
