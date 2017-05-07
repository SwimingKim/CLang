using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItemAlienHealth : CAlienHealth {
    
	public override void DoDestroy()
	{
        Vector2 position = transform.position;

        Debug.Log("아이템 몬스터 죽음");
        GameObject.Find("GameManager").GetComponent<CItemDrop>().ItemDrop(position);

        base.DoDestroy();
    }

}
