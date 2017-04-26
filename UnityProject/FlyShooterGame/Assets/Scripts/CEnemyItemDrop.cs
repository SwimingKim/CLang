using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 적기가 아이템을 떨굼
public class CEnemyItemDrop : MonoBehaviour {

    // 아이템 프리팹
    public GameObject[] _itemPrefab;

	public void ItemDrop()
	{
        // 아이템 번호를 설정함
        int itemNum = Random.Range(0, _itemPrefab.Length);

        // 아이템을 생성함
        Instantiate(_itemPrefab[itemNum], transform.position, Quaternion.identity);
    }

}
