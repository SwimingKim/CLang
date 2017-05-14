using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTankTargetLookRotation : MonoBehaviour
{

    public Transform _lookTarget;

    void Start()
    {

    }

    void Update()
    {
        // 방향 벡터를 구함
        Vector3 direction = _lookTarget.position - transform.position;
        direction.y = 0f;

        // 회전 쿼터니언을 구함
        Quaternion rot = Quaternion.LookRotation(direction.normalized);

        // 회전
        // transform.rotation = rot;
		// 부드럽게 회전
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 0.02f);

		// 방향과 방향간의 각도 구하기
        Quaternion qt = Quaternion.FromToRotation(transform.forward, direction.normalized);
        Vector3 eulerAngle = qt.eulerAngles; // 쿼터니언 -> 오일러
        Debug.Log("타겟과의 각도 = " + eulerAngle.y);

    }

}
