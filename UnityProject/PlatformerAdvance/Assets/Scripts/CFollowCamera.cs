using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFollowCamera : MonoBehaviour {

    public Transform _targetPlayer; // 타겟
    public Vector3 _offset; // 카메라와 타겟의 유지 거리
    public float _smoothValue; // 부드러운 정도

	void FixedUpdate()
	{
		// 플레이어가 연결되어 있다면
		if (_targetPlayer)
		{
            // 플레이어의 위치를 찾음
            Vector3 targetPos = new Vector3(_targetPlayer.position.x, _targetPlayer.position.y, transform.position.z);

			// Vector3.Slerp // 회전에 대한 보간
			// Vector3.Lerp // 이동에 대한 보간

            // 카메라의 위치를 플레이어에 맞춤
            transform.position = Vector3.Lerp(transform.position, targetPos + _offset, _smoothValue);

        }

	}

}
