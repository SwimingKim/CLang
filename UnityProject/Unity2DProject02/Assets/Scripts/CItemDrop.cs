using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItemDrop : MonoBehaviour {

    public GameObject[] _itemPrefab;

	public void ItemDrop()
	{
        int itemNum = Random.Range(0, _itemPrefab.Length);

        float randX = Random.Range(-1.5f, 1.5f);
        float randY = Random.Range(-1.5f, 1.5f);

        Vector2 pos = transform.position;
        pos.x += randX;
        pos.y += randY;

        Instantiate(_itemPrefab[itemNum], pos, Quaternion.identity);

        Debug.Log("아이템 생성");
    }

}
