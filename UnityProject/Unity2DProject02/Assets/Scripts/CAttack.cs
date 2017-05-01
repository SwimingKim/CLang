using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAttack : MonoBehaviour
{
    public GameObject _createPrefab;
    protected Transform createPos;

    public int _bombMax; // 캐릭터가 버블을 생성할 수 있는 개수

	void Start()
	{
        StartCoroutine("MakeBubbleCoroutine");
	}

    // 타일의 충돌을 통해 버블 생성 위치 조정
    void OnTriggerStay2D(Collider2D other)
    {
        createPos = other.transform;
    }

	IEnumerator MakeBubbleCoroutine()
	{
        yield return new WaitForSeconds(1f);

        MakeBubble();
        yield return new WaitForSeconds(9f);

        StartCoroutine("MakeBubbleCoroutine");
    }

    protected bool MakeBubble()
    {
		GameObject[] bubbles = GameObject.FindGameObjectsWithTag("Bubble");

        // 현재 위치에 버블이 있는지 확인
        foreach (GameObject item in bubbles)
        {
            if (item.transform.position == createPos.position)
            {
                return false;
            }
        }
        // 버블 최대 개수를 초과하는지 확인
        if (_bombMax <= bubbles.Length) return false;

        Instantiate(_createPrefab, createPos.position, Quaternion.identity);

        return true;
    }

}
