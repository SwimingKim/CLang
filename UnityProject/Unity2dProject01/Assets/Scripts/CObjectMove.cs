using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CObjectMove : MonoBehaviour {

	public Rigidbody2D _rigidbody;
    public float _speed;
    public Vector2 _direction;

    // Use this for initialization
    void Start () {

        _rigidbody.velocity = _direction.normalized * _speed;

    }
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < -18)
        {
            Destroy(gameObject);
        }
		
	}
}
