using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMiniShipItem : MonoBehaviour {

    public GameObject _minishipPrefab; // 비행기 프리팹

    CInstallMiniShip _playerShipInstall; // 플레이어 설치 컴포넌트

    void Start()
    {
        _playerShipInstall = GameObject.Find("PlayerShip").GetComponent<CInstallMiniShip>();
    }

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.name == "PlayerShip")
		{
            // 미니 비행기를 설치함
            _playerShipInstall.InstallMiniShip(_minishipPrefab);

            // 아이템을 파괴함
            Destroy(gameObject);
        }
		
	}

}
