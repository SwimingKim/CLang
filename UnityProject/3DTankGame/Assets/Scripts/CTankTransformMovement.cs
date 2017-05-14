using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTankTransformMovement : MonoBehaviour {

    public float _moveSpeed; // 이동 속도
    public float _rotateSpeed; // 회전 속도
	
	void Update () {
        
		float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 앞뒤로 이동
        transform.Translate(Vector3.forward * v * _moveSpeed * Time.deltaTime);

        // 왼쪽 오른쪽 회전
        transform.Rotate(Vector3.up * h * _rotateSpeed * Time.deltaTime);

    }

}
