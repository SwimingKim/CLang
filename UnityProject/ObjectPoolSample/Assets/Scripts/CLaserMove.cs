using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLaserMove : MonoBehaviour {

    public float _speed;
    float _oriSpeed;
    public float _lifeTime;

    public Vector2 _direction;

	void OnEnable()
	{
        Debug.Log("OnEnable");

        _oriSpeed = _speed;
        Invoke("Die", _lifeTime);
    }

	void OnDisable()
	{
        Debug.Log("OnDisable");

        CancelInvoke("Die");
    }

	void Update()
	{
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
	
	void Die()
	{
        _oriSpeed = 0f;

        CObjectPool.current.PoolObject(gameObject);
    }
	

}
