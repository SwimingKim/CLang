using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSortingOrder : MonoBehaviour {

    public int _sortingId = 0;

    void Start () {
		
    }

	public void InitSorting(int sortingId)
	{
		// 컴포넌트타입[] 자식컴포넌트배열 = GetComponentsInChildren<컴포넌트타입>();
		// : 현재 오브젝트의 자식 오브젝트들 중 지정된 컴포넌트타입을 컴포넌트을을 구함
        SpriteRenderer[] spriteRederer = GetComponentsInChildren<SpriteRenderer>();

		// 10단위의 정렬 아이디 값을 구함
		sortingId = _sortingId * 10;

		// 자식 오브젝트들의 SpriteRenderer 컴포넌트들을 순회하면서
		foreach (SpriteRenderer spRenderer in spriteRederer)
		{
			// 스프라이트 렌더러의 정렬 수치에 지정한 정렬 아이디값을 가산함
            // spRenderer.sortingOrder = spRenderer.sortingOrder + sortingId;
            spRenderer.sortingOrder += sortingId;
        }

	}



}
