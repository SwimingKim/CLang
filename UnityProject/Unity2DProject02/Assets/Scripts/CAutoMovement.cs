using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAutoMovement : CMovement {

    public float _walkTime;
    Rigidbody2D _bossRigidbody;

    void Start () {
        _bossRigidbody = GetComponent<Rigidbody2D>();
        InvokeRepeating("Walk", _walkTime, _walkTime);

        X_LIMIT_POS = 6f;
        Y_LIMIT_POS = 2f;
    }

	void Update()
	{
        CameraArea();
	}

	void Walk()
	{
        // 랜덤으로 방향 지정
        int ranDirection = Random.Range(0, 3);
        Vector2 direction = new Vector2(0, 0);
        if (ranDirection == 0) direction = new Vector2(1, 0);
        if (ranDirection == 1) direction = new Vector2(-1, 0);
        if (ranDirection == 2) direction = new Vector2(0, 1);
        if (ranDirection == 3) direction = new Vector2(0, -1);

        // 꼭대기에 몰린 경우 방향을 조정
        // 1 2
        // 3 4
        Vector2 pos = transform.position;
        if (pos == new Vector2(-6, 2)) direction = new Vector2(1, -1);
        if (pos == new Vector2(6, 2)) direction = new Vector2(-1, -1);
        if (pos == new Vector2(-6, -2)) direction = new Vector2(1, 1);
        if (pos == new Vector2(6, -2)) direction = new Vector2(-1, 1);
        _bossRigidbody.AddForce(direction * _speed * 2f);
    }
	
}
