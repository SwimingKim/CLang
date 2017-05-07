using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItemDrop : MonoBehaviour {

    public GameObject[] _itemPrefab;

    public void ItemDrop(Vector2 pos)
    {
        int itemNum = Random.Range(0, _itemPrefab.Length);

        float randX = Random.Range(-1.5f, 1.5f);
        float randY = Random.Range(-1.5f, 1.5f);

        pos.x += randX;
        pos.y += randY;

        Instantiate(_itemPrefab[itemNum], pos, Quaternion.identity);
    }

    IEnumerator ItemDropCoroutine(Vector2 pos)
    {
        yield return new WaitForSeconds(1.5f);

        int itemNum = Random.Range(0, _itemPrefab.Length);
        Instantiate(_itemPrefab[itemNum], pos, Quaternion.identity);
    }

}
