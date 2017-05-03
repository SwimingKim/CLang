using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBoxCollision : MonoBehaviour
{
    // 1회만 충돌 체크하도록 확인
    bool isCollision = true;

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Bomb" && isCollision)
		{
            isCollision = false;

            RemoveBox();
        }
	}

    public void RemoveBox()
    {
        // 60%의 확률로 드랍
        if (Random.Range(0, 10) < 6)
        {
            Vector2 position = transform.position;

            GameObject.Find("GameManager").GetComponent<CItemDrop>().StartCoroutine("ItemDropCoroutine", position);
        }
        Destroy(gameObject);

    }


}