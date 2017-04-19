using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CObjectMove : MonoBehaviour {

    public Rigidbody2D _rigidbody2d; // 강체(물리엔진) 컴포넌트

    public float _speed; // 이동속도

    public Vector2 _direction; // 이동방향

    // Use this for initialization
    void Start () {

        _rigidbody2d.velocity = _direction.normalized * _speed;

    }
	
	// Update is called once per frame
	void Update () {

        // 게임이 종료 되었으면
        if (CGameManager.isGameStop)
        {
            // 이동을 정지함
            _rigidbody2d.velocity = Vector2.zero;
        }

        // 현재 기둥이 왼쪽 -12f 지점을 넘으면 삭제함
		if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
	}
}
