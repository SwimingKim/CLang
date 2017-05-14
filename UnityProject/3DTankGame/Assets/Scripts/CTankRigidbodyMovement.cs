using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTankRigidbodyMovement : MonoBehaviour
{

    public float _moveSpeed; // 이동 속도
    public float _rotateSpeed; // 회전 속도

    Rigidbody _rigidbody;

    float h, v;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        // 월드 축에 맞춰서 방향축을 맞춰줌
        Vector3 moveDirection = transform.TransformDirection(new Vector3(0f, 0f, v));

        // 물리엔진을 이용해서 이동함 (충돌 이슈와 보간이 적용됨)
        _rigidbody.MovePosition(_rigidbody.position + (moveDirection.normalized * _moveSpeed * Time.deltaTime));

        // 오일러 회전 각도 생성
        Vector3 eulerRot = new Vector3(0f, h * _rotateSpeed, 0f);
        // 오일러 -> 쿼터니언
        Quaternion deltaRot = Quaternion.Euler(eulerRot * Time.fixedDeltaTime);
        // 회전
        _rigidbody.MoveRotation(_rigidbody.rotation * deltaRot);
    }

}
