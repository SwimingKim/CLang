using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInputMovement : CMovement {

	void Update () {
        // 수평 키입력 여부 체크
        float h = Input.GetAxisRaw("Horizontal");

		/*
		// 수평 방향키를 눌렀다면
		if (h == 0)
		{
			// 걷기 애니메이션 상태를 정지로
            _animator.SetBool("Walk", false);
        }
		else
		{
			// 걷기 애니메이션 상태를 걷기로
            _animator.SetBool("Walk", true);
        }
		*/

		// 만약 스윙 애니메이션이 실행 중이라면
		// if (!_animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") && !_animator.GetCurrentAnimatorStateInfo(0).IsName("Walk")) return; // 이동하지 말아라
		if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Swing")) return; // 이동하지 말아라

        // 삼항연산자 : (조건) ? 참결론 : 거짓결론
        _animator.SetBool("Walk", (h == 0) ? false : true);

		// 만약(if) 왼쪽으로 보고 있는데(_isRightFace==false)
		// 오른쪽 키를 누르거나 (h>0)
		// 오른쪽으로 보고 있는데(_isRightFace==true) 왼쪽 키를 누르면(h<0)
		if ((h > 0 && !_isRightFace) || (h < 0 && _isRightFace))
		{
            Flip(); // 캐릭터를 반전해라
        }

        // 이동 
        transform.Translate(Vector2.right * h * _speed * Time.deltaTime);
    }

    // 속도 업!!
    public void SpeedUp(float upValue)
    {
        _speed *= upValue;
        _animator.speed = 1.5f;
    }



	
}
