using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItemEnemyShipHealth : CShipHealth {

	public override void DoDestroy()
	{
		// 컴포넌트타입 변수 = GetComponent<컴포넌트타입>()
		// - 현재 스크립트와 같은 계층에 있는 컴포넌트 중에 지정한 타입의 컴포넌트를 참조함
		CEnemyItemDrop _itemDrop = GetComponent<CEnemyItemDrop>();

		if (_itemDrop != null)
		{	
			// 아이템을 떨군다
            _itemDrop.ItemDrop();
        }

        base.DoDestroy();
    }


}
