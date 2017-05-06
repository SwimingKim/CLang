using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAutoShot : MonoBehaviour
{

    public GameObject _laserPrefab;
    public float _shotDelay;
    public Transform[] _shotPositions;

    void Start()
    {
        StartCoroutine("AutoShotCoroutine");
    }

	IEnumerator AutoShotCoroutine()
	{
        while (true)
        {
            for (int i = 0; i < _shotPositions.Length; i++)
            {
                // Instantiate(_laserPrefab, shotPosition.position, shotPosition.rotation);

                // 오브젝트 풀에서 오브젝트(레이저)를 뺴냄
                GameObject obj = CObjectPool.current.GetObject(_laserPrefab);
                // 위치와 회전을 설정함
                obj.transform.position = _shotPositions[i].position;
                obj.transform.rotation = _shotPositions[i].rotation;
                // 오브젝트를 활성화함
                obj.SetActive(true);

                // Debug.Log(shotPosition.position + "에서 총알을 발포함!!");
            }
            yield return new WaitForSeconds(_shotDelay);
        }
    }

}
