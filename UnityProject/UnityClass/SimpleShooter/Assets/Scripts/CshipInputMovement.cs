using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CshipInputMovement : MonoBehaviour {

	public float _speed; // 프레임당 이동 속도(크기)

	const float X_LIMIT_POS = 8f; // 좌우 경계 크기
	const float Y_LIMIT_POS = 4f; // 상하 경계 크기
	
	// [Start 특징]
	// 오브젝트의 모든 컴포넌트들이 생성된 후
	// 첫번쨰 렌더링을 수행하기 바로 전 딱 1회만 호출됨
	// 주로 현재 스크립트 컴포넌트의 초기화 작업에 사용됨
	private void Start()
	{
		// transform.position : 위치(Vector3)
		// 현재 오브젝트를 5,0,0의 위치로 이동시킴
		// transform.position = new Vector3(5, 0, 0);
	}


	// [Update 특징]
	// 렌더링 바로 전에 자동 호출되는 유니티 이벤트 메소드
	// FPS가 30일 경우 초당 30회 호출됨
	// 렌더링 단위마다 해야할 일이 있다면 여기에 작성함
	void Update () {
		
		// Input.GetAxisRaw("수평 또는 수직") : 수평/수직 키입력을 받아옴
		// 리턴값 : 1(오른쪽), 0(정지), -1(왼쪽)
		float h = Input.GetAxisRaw("Horizontal");
		// 리턴값 : 1(위쪽), 0(정지), -1(아래쪽)
		float v = Input.GetAxisRaw("Vertical");

		// Vector : 위치, 방향, 거리를 나타내는 단위
		// [Vector2 용도]
		// - 2차원 방향을 나타내는 단위 -> (1, 0) : 오른쪽
		// - 2차원 위치을 나타내는 단위 -> (3, 2) : 오른쪽 3 위쪽 2
		// - 거리를 나타내는 단위 -> (10, 0) : 가로 10
		Vector2 direction = new Vector2(h, v);

		// 디버그 메세지를 출력함 (콘솔뷰)
		// Debug.Log("이동하려는 방향 = "+direction);

		// Transform.Translate() : Transform 컴포넌트에 이동을 요청함
		// Translate(방향 * 이동크기 * Time.deltaTime);
		// Time.deltaTime : 이동 보간 시간 (서로 다른 FPS의 이동 보간을 수행함)
		transform.Translate(direction * 5f * _speed * Time.deltaTime);

		// [퀴즈]
		// 왼쪽, 오른쪽, 위쪽, 아래쪽 경계선을 넘지 않도록
		// 처리하는 코드를 작성하시오.
		// transform.Translate(direction * 5f * _speed * Time.deltaTime);

		/*
		if (transform.position.x < -8f)
		{
			transform.position = new Vector3(-8, transform.position.y, 0);
		}
		if (transform.position.x > 8f)
		{
			transform.position = new Vector3(8, transform.position.y, 0);
		}
		if (transform.position.y > 4f)
		{
			transform.position = new Vector3(transform.position.x, 4f, 0);
		}
		if (transform.position.y < -4f)
		{
			transform.position = new Vector3(transform.position.x, -4f, 0);
		}
		 */

		// Mathf.Sign(값) : 음수값이나 0이 들어오면 -1을
		// 양수가 들어오면 1을 리턴하는 함수
		Vector2 pos = transform.position;
		if (pos.x < -X_LIMIT_POS || pos.x > X_LIMIT_POS)
		{
			pos.x = Mathf.Sign(pos.x) * X_LIMIT_POS;
		}
		if (pos.y < -Y_LIMIT_POS || pos.y > Y_LIMIT_POS)
		{
			pos.y = Mathf.Sign(pos.y) * Y_LIMIT_POS;
		}
		transform.position = pos;


	}
}
