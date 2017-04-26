using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 유니티 UI 사용
using UnityEngine.UI;

public class CPlayerShipHealth : CShipHealth {

    // 체력바
    public Image _healthProgress;

	// 데미지에 해당하는 체력을 감소시킨 후 표시함
	public override int HpDown(float damage)
	{
        //  데미티를 게이지 비율에 맞춰 계산 후 감소함
        _healthProgress.fillAmount -= (damage * 0.01f);

        // 현재 남은 체력값을 리턴함
        return base.HpDown(damage);
    }

    // 플레이어의 체력을 회복함
    public void HpUp(int upValue)
    {
        _hp += upValue; // 체력 증가

        // 체력이 100을 초과하면 100을 설정함
        _hp = (_hp > 100) ? 100 : _hp;

        // 체력 게이지 설정
        _healthProgress.fillAmount = _hp * 0.01f;
    }

}
