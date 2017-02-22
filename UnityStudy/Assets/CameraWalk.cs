﻿using UnityEngine;
using System.Collections;

public class CameraWalk : MonoBehaviour
{
	GameObject ball;
	// Use this for initialization
	void Start ()
	{
		ball = GameObject.Find ("Ball");
	}
	
	// Update is called once per frame
	void Update ()
	{
//		Debug.Log ("I am Camera. And ball is at " + ball.transform.position.z);
		transform.position = new Vector3 (0, ball.transform.position.y + 3, ball.transform.position.z - 14);
	}
}
