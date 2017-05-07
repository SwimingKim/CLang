using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenerator : MonoBehaviour {

	// 생성 위치들
	public Transform[] _genPositions;

    // 생성 지연 시간들
    public float _minGenDelayTime;
    public float _maxGenDelayTime;

    // 생성 오브젝트 프리팹
    public GameObject[] _genPrefabs;

	protected virtual void Start()
	{
        StartCoroutine("GenCoroutine");
    }
	
}
