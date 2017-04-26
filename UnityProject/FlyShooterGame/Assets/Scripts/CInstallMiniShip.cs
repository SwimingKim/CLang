using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInstallMiniShip : MonoBehaviour {

	// 아기 비행기 생성 위치
    public Transform[] _miniShipPos;

	public void InstallMiniShip(GameObject miniShipPrefab)
	{
		// 비행기 생성 위치를 체크함
		foreach (Transform genPos in _miniShipPos)
		{
			// 현재 위치에 이미 비행기가 있다면 다음 위치로 넘김

			// Transform.childCount : 현재 오브젝트의 자식 오브젝트의 갯수
			if (genPos.childCount > 0) continue;

            // 미니 비행기를 생성함
            GameObject miniShip = Instantiate(miniShipPrefab, genPos.position, genPos.rotation);

			// 생성한 미니 비행기를 현재 위치의 자식으로 등록함
			
			// Transform.SetParent(부모Transform) : 지정한 부모의 자식 오브젝트로 설정함
            miniShip.transform.SetParent(genPos);

            break;
        }




	}

}
