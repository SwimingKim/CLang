using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInputAttack : MonoBehaviour
{

    Animator _animator;

    int _attackIndex = 1;

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public bool IsAttack()
    {
        // 전사의 공격 상태는 Attack1 ~ Attack3 애니메이션 상태를 의미함
        if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Attack1") ||
       		_animator.GetCurrentAnimatorStateInfo(0).IsName("Attack2") ||
        	_animator.GetCurrentAnimatorStateInfo(0).IsName("Attack3"))
        {
            return true;
        }

        return false;
    }

	void Update()
	{
        Attack();
    }

	void Attack()
	{
		// 왼쪽의 알트키를 누르면
		if (Input.GetKeyDown(KeyCode.X))
		{
			if (IsAttack()) return;

            _animator.SetTrigger("Attack" + _attackIndex++);

			if (_attackIndex > 3) _attackIndex = 1;
        }
	}


}
