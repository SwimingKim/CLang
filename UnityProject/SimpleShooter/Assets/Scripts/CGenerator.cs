using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenerator : MonoBehaviour {

	// 위치 오브젝트들의 Transform 컴포넌트를 참조할 배열을 선언함
	public Transform[] _positions;

	// 운석 프리팹을 참조함
	public GameObject[] _meteorPrefabs;
	// 방패 프리팹
	public GameObject _shieldPrefab;

	public int _prefabInterval;

	public float _createTime; // 운석 생성 시간

	// Use this for initialization
	void Start () {
		// 임시로 운석을 생성함
		// CreateObject();

		// InvokeRepeating("메소드명", 시작지연시간, 반복지연시간)
		InvokeRepeating("CreateMeteor", _createTime, _createTime); // 2초마다 운석을 생성함
		InvokeRepeating("CreateShield", 5f, 10f); // 10초마 쉴드 아이템을 생성함 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// 쉴드를 생성함
	void CreateShield()
	{
		// 랜덤하게 위치 번호를 추첨함
		int posNum = Random.Range(0, _positions.Length);
		
		// 프리팹을 게임오브젝트로 생성함
		// Instantiate(프리팹 참조, 생성위치, 회전);
		Instantiate(_shieldPrefab, _positions[posNum].position, Quaternion.identity);
	}

	
	void CreateMeteor() {
		// int 정수 = Random.Range(시작값, 끝값+1);
		// float 정수 = Random.Range(시작값, 끝값);
		int posNum = Random.Range(0, _positions.Length);

		// 4가지 경우의 타입을 설정하여
		int meteorType = Random.Range(0, _prefabInterval+1);

		// 3:1 비율로 운석 타입을 지정함
		/*
		if (meteorType < 3)
		{
			meteorType = 0;
		} 
		else
		{
			meteorType = 1;
		}
		 */
		meteorType = (meteorType < _prefabInterval) ? 0 : 1;
 
		// 프리팹을 게임오브젝트로 생성함
		// Instantiate(프리팹 참조, 생성위치, 회전)
		// Instantiate(_meteorPrefabs, new Vector2(0f, 9f), Quaternion.identity);
		Instantiate(_meteorPrefabs[meteorType], _positions[posNum].position, Quaternion.identity);
	}

}
