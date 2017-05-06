using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPlayerHealth : MonoBehaviour {

	// 플레이어 사망 여부
	public bool _isDie = false;

    public Image[] _hpImage;
    public int _hpCount = 3;

    public Animator _animator;

	// 체력이 감소됨
	public void HpDown()
	{
        // 체력 갯수 감소
        _hpImage[--_hpCount].enabled = false;

		// 체력이 0이면
		if (_hpCount <= 0)
		{
            Die(); // 사망 처리
        }
    }

	// 사망 처리
	public void Die()
	{
        // 사망 여부를 설정함
        _isDie = true;

		// 피격 콜라이더를 비활성화 함
        GetComponent<BoxCollider2D>().enabled = false;

        _animator.SetTrigger("Die"); // 사망 애니메이션 실행
    }

    // 사망 애니메이션이 끝나면 게임을 종료해라
    void DieAnimComplete()
    {
        GameObject.Find("GameManager").SendMessage("EndGame");
    }

}
