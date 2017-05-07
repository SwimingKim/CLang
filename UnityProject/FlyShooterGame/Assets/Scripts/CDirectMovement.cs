using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDirectMovement : MonoBehaviour {

    public Vector2 _direction; // 방향
    public float _speed; //속도
    float _oriSpeed;

    private void Start()
    {
        _oriSpeed = _speed; // 시작할때 속도를 지정함
    }

	void Update () {
        // 지정한 방향과 속도로 이동함
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    // 비행기의 속도를 정지함
    public void Stop()
    {
        _speed = 0;
    }

    // 비행기의 이동 속도를 복원함
    public void Resume()
    {
        _speed = _oriSpeed;
    }

}
