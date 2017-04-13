using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMeteorMove : MonoBehaviour {
	Vector3 _direction; // 이동방향
	public float _speed; // 이동속도
	
	// Use this for initialization
	void Start () {
		// GameObject.Fine("오브젝트이름") : 지정한 이름을 가진 오브젝트를 찾아냄
		GameObject playerShip = GameObject.Find("PlayerShip");

		// GameObject.GetComponent<컴포넌트타입>()
		// : 게임오브젝트에 속한 여러개의 컴포넌트 중에 지정한 타입의 컴포넌트를 구함
		Transform playerShipTr = playerShip.GetComponent<Transform>();

		// 방향 = 이동목적지위치 - 이동대상의 위치
		_direction = playerShipTr.position - transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		// transform.Translate(방향 * 속도 * Time.deltaTime);
		// Vector3.normalized : 크기와 방향을 가진 벡터를 크기가 1인 방향만을 가진 벡터로 변환함
		transform.Translate(_direction.normalized * _speed * Time.deltaTime);
	}
}
