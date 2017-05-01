using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItemAlienHealth : CAlienHealth {
    
	public override void DoDestroy()
	{
        CItemDrop _itemDrop = GetComponent<CItemDrop>();
		if (_itemDrop != null)
		{
            _itemDrop.ItemDrop();
        }
        base.DoDestroy();
    }

}
