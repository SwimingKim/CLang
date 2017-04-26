using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInputMovement : MonoBehaviour {

	// 경계 수치
	const float LIMIT_POS_Y = 4.5f;
    const float LIMIT_POS_X = 2.24f;

    // 비행기 이동 속도
    public float _speed;

	void Update () {

        // -1, 0, 1
		// 방향키값 입력
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

		// 방향 벡터 생성
        Vector2 direction = new Vector2(h, v);
		// 비행기 이동
        transform.Translate(direction * _speed * Time.deltaTime);

        // 화면 경계 이동 제한 처리
        Vector2 pos = transform.position;
        if (Mathf.Abs(pos.x) > LIMIT_POS_X)
		{
            pos.x = Mathf.Sign(pos.x) * LIMIT_POS_X;
        }
		if (Mathf.Abs(pos.y) > LIMIT_POS_Y)
		{
            pos.y = Mathf.Sign(pos.y) * LIMIT_POS_Y;
		}
        transform.position = pos;

    }


}
