using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStoneGenerator : CGenerator {


	protected override void Start()
	{
        base.Start();
    }

	IEnumerator GenCoroutine()
	{
		while (true)
		{
            // 운석 생성 위치 선정
            int genPosNum = Random.Range(0, 5);

            // 현재 생성할 운석의 위치를 참조함
            Transform genPosition = _genPositions[genPosNum];

			// 운석 생성 위치의 자식 갯수가 1개 이상이면
			if (genPosition.childCount > 0)
			{
                yield return null;
				// 이 위치에 생성하지 않음
                continue;
            }

            // 운석 타입
            int meteorType = Random.Range(0, _genPrefabs.Length);

            // 운석 생성
            GameObject meteor = Instantiate(_genPrefabs[meteorType], genPosition.position, Quaternion.identity);

            // 운석이 생성된 위치를 부모로 설정함
            meteor.transform.SetParent(genPosition);

            // 생성 지연 시간을 구함
            float delayTime = Random.Range(_minGenDelayTime, _maxGenDelayTime);

            // 다음 생성까지 시간 지연
            yield return new WaitForSeconds(delayTime);

        }
	}

}
