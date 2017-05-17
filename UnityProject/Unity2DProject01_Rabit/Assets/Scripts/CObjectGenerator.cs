using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CObjectGenerator : MonoBehaviour {

    // 위치를 고정할 것인지 변동할 것인지 확인
    public enum POSY_TYPE {
        FIXED, VARIABLE
    }
    public POSY_TYPE _yType = POSY_TYPE.FIXED;

    public GameObject[] _objectPrefab;

    public float _createStartTime;
    public float _createDelayTime;
	public Transform _createPos;

    // Use this for initialization
    void Start () {
        InvokeRepeating("CreateObject", _createStartTime, _createDelayTime);
    }

	void CreateObject()
	{
		int rand = Random.Range(0, _objectPrefab.Length);
        float yScope = _yType == POSY_TYPE.VARIABLE ? Random.Range(-2f, 2f) : 0;

        Vector2 createPos = new Vector2(_createPos.position.x, _createPos.position.y+yScope);
        Instantiate(_objectPrefab[rand], createPos, Quaternion.identity);

    }

}
