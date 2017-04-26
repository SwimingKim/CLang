using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyGenerator : MonoBehaviour {

	// 적기 프리팹
    public GameObject[] _enemyPrefab;

    // 생성 위치 참조 배열
    public Transform[] _genPos;

    public float _delayMinTime; // 생성 지연 최소 간격 시간
    public float _delayMaxTime; // 생성 지연 최대 간격 시간

	void Start()
	{
        // 지연 시간 뒤에 적기를 생성함
        float delayTime = GetDelayTime();

        // 지연 시간 뒤에 적기를 생성함
        Invoke("CreateEnemy", delayTime);
    }

	// 적기 생성
	public void CreateEnemy()
	{
		// 생성 위치의 배열 인덱스 번호를 랜덤하게 추첨함
        int posNum = Random.Range(0, _genPos.Length);

        float delayTime = GetDelayTime();

        // 4(이동적기):4(발포적기):2(3발포적기) 비율로 적기를 생성하시오.
        
        // 비율을 구하고
        int rate = Random.Range(0, 10);
        GameObject enemyPrefab = null;

        if (rate > 7) // 20퍼센트 확률로 2번 비행기 생성
        {
            enemyPrefab = _enemyPrefab[2];
        }
        else if (rate > 5) // 20퍼센트 확률로 1번 비행기 생성
        {
            enemyPrefab = _enemyPrefab[1];
        }
        else // 60퍼센트 확률로 0번 비행기 생성
        {
            // enemyPrefab = _enemyPrefab[0];
            enemyPrefab = _enemyPrefab[3];
        }

        // 적기 생성
        Instantiate(enemyPrefab, _genPos[posNum].position, Quaternion.identity);
    
        // 지연 시간 뒤에 적기를 생성함
        Invoke("CreateEnemy", delayTime);
    }

	float GetDelayTime()
	{
        // 생성 지연시간 범위를 랜덤하게 추첨함
        float delayTime = Random.Range(_delayMinTime, _delayMaxTime);

        return delayTime;
    }


}
