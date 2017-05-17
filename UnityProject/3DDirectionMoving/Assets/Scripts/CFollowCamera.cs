using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFollowCamera : MonoBehaviour
{

	public Transform _target; // 추적 타겟
	public float _smoothValue; // 이동 보간(부드러움)
	public Vector3 _offset; // 추적 간격

	void Start () {
		// 카메라 위치 초기화
		transform.position = Vector3.zero;
		transform.position = _target.position;

		// 타겟 간격 위치 설정
		transform.position = _target.position + _offset;
	}

	private void LateUpdate()
	{
		if (_target == null) return;

		// 업데이트시 간격 위치 갱신
		Vector3 targetCampPos = _target.position + _offset;

		// 부드럽게 위치 이동 설정
		transform.position = Vector3.Lerp(transform.position, targetCampPos, _smoothValue + Time.deltaTime);
	}

}
