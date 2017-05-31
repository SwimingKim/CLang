﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStar : MonoBehaviour {

	public float _dirValue;
	public float _maxSpeed;
	Rigidbody2D _rigidbody2d;

	public GameObject _destroyEffectPrefab;
	public float _destroyEffectDestroyTime;

	public void Init(bool isRightDir)
	{
		_rigidbody2d = GetComponent<Rigidbody2D>();
		_dirValue = (isRightDir) ? 1 : -1;
		
		Move();

		Invoke("Destroy", 1.2f);
	}

	public void Move()
	{
		_rigidbody2d.velocity = new Vector2(_dirValue * _maxSpeed, _rigidbody2d.velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Box")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}

	void Destroy()
	{
		Destroy(gameObject);	
	}


}
