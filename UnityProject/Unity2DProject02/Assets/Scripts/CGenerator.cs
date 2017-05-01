using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenerator : MonoBehaviour {

    public float _createDelayTime;
    public Transform _createPos;
    public GameObject[] _createPrefab;

    // Use this for initialization
    void Start () {
        InvokeRepeating("CreateObject", _createDelayTime, _createDelayTime);
    }
	
	void CreateObject()
	{
        int rand = Random.Range(0, _createPrefab.Length);
        
        // int num = 0;
        // 아이템(4) : 이동(2) : 공격(2)
        // if (rand > 5)
        // {
        //     num = 0;
        // }
        // else if (rand > 2)
        // {
        //     num = 1;
        // }
        // else
        // {
        //     num = 2;
        // }

        Instantiate(_createPrefab[rand], _createPos.position, Quaternion.identity);
    }


}
