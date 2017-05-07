using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이동 공통
public class CMovement : MonoBehaviour {

	public float _speed; // 속도
	public bool _isRightFace; // 시선

    protected Animator _animator;

    protected virtual void Start()
    {
        // 수동 컴포넌트 참조 (연결)
        _animator = GetComponent<Animator>();

        // 애니메이션 재생
        // Animator.SetBool("파라미터이름", 값) : bool 파라미터 애니메이션 실행
        // Animator.SetInt("파라미터이름", 값) : bool 파라미터 애니메이션 실행
        // Animator.SetFloat("파라미터이름", 값) : bool 파라미터 애니메이션 실행
        // Animator.SetTrigger("파라미터이름", 값) : bool 파라미터 애니메이션 실행
        // _animator.SetBool("Walk", true);
    }

    // 캐릭터 수평 반전
    public void Flip()
	{
        // Transform의 스케일 벡터 받음
        Vector3 scale = transform.localScale;

        // 시선 반전
        scale.x *= -1;
        transform.localScale = scale;

        // 시선값 반전
        _isRightFace = !_isRightFace;
    }

}
