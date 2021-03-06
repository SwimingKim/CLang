﻿using System.Collections;
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
    void OnTriggerEnter2D(Collider2D other)
    {
        // 현재 위치에 박스나 버블이 있는지 확인
        if (other.transform.childCount == 0)
        {
            createPos = other.transform;
        }
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
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("EnemyBubble");
        foreach (GameObject item in enemies)
        {
            if (item.transform.position == createPos.position) return false;
        }

        // 버블 최대 개수를 초과하는지 확인
        // 버블을 만들 지점이 있는지 확인
        // 박스가 있는지 확인
        if (_bombMax <= GameObject.FindGameObjectsWithTag("Bubble").Length || createPos == null || createPos.transform.childCount != 0) return false;

        GameObject gameObject = Instantiate(_createPrefab, createPos.position, Quaternion.identity);
        gameObject.transform.SetParent(createPos);

        return true;
    }

}