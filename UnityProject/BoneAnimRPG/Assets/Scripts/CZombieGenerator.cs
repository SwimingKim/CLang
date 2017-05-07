using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CZombieGenerator : CGenerator {

    public int _zombieCount = 0; // 좀비 생성 카운트

	protected override void Start()
	{
        StartCoroutine("GenCoroutine");
    }

	IEnumerator GenCoroutine()
	{
		while (true)
		{
            // 좀비 생성 위치 선정	
            int genPosNum = Random.Range(0, 2);

            _zombieCount++; // 좀비 생성 카운트

            // 좀비 생성
            GameObject zombie = Instantiate(_genPrefabs[0], _genPositions[genPosNum].position, Quaternion.identity);

            // 생성한 좀비의 스프라이트 본들을 정렬함
            zombie.GetComponent<CSortingOrder>().InitSorting(_zombieCount);
            zombie.SendMessage("InitSorting", _zombieCount);

            // 생성 지연 시간을 구함
            float delayTime = Random.Range(_minGenDelayTime, _maxGenDelayTime);

            // 다음 생성까지 시간 지연
            yield return new WaitForSeconds(delayTime);

        }
	}



}
