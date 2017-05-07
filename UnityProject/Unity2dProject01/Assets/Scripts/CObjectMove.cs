using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CObjectMove : MonoBehaviour {

	public Rigidbody2D _rigidbody;
    public float _speed;
    public Vector2 _direction;

    // Use this for initialization
    protected virtual void Start () {
        _rigidbody.velocity = _direction.normalized * _speed;
    }
	
	// Update is called once per frame
	protected virtual void Update () {

        // 화면에서 밀리면 삭제
        if (transform.position.x < -18)
        {
            Destroy(gameObject);
        }
		
	}
}
