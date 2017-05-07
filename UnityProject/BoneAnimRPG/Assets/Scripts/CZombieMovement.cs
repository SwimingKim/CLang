using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CZombieMovement : CMovement {

    protected override void Start () {

        base.Start();

        // 좀비가 생성된 위치가 왼쪽일 경우
        if (transform.position.x < 0) Flip(); // 캐릭터를 반전 시킴
    }
	
	void Update () {
        /*
		// 이동 방향
        float h = -1;
		// 오른쪽을 보고 있으면
        if (_isRightFace) h = 1; // 오른쪽 방향으로

		// 이동
        transform.Translate(Vector2.right * h * _speed * Time.deltaTime);
		*/

		// 지정된 시선의 방향으로 이동항
        transform.Translate(Vector2.right * ((_isRightFace) ? 1 : -1) * _speed * Time.deltaTime);

        // 좀비의 위치가 10을 넘어가면 파괴하라
        if (Mathf.Abs(transform.position.x) > 10) Destroy(gameObject);
    }

    // 속도 업!!
    public void SpeedUp(float upValue)
    {
        _speed += upValue;
    }

}
