using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTouch : MonoBehaviour {

    // 이동 오브젝트의 Transform
    Transform _moveTr = null;
    Vector3 touchPos;

    Rigidbody2D _rigidbody;

    void Start()
	{
        _rigidbody = GetComponent<Rigidbody2D>();
    }
  
    // Update is called once per frame
    void Update()
    {
        // 마우스 다운 체크
        if (Input.GetMouseButtonDown(0))
        {
            // ScreenToWorldPoint() : 입력좌표 -> 월드좌료 변환
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            touchPos = new Vector2(wp.x, wp.y);
  
            Debug.Log("터치 좌표 => " + touchPos);
            // Physics2D.OverlapPoint(좌표)
            // => 해당 좌표에 충돌 오브젝트가 있는지 포인트 단위로 검출함
            // Physics2D.OverlapPoint : 포인트 단위 검출
            // Physics2D.OverlapCircle : 원단위 검출
            // Physics2D.OverlapArea : 사각형 단위 검출
            // Collider2D collider2d = Physics2D.OverlapPoint(touchPos);
            // if (collider2d != null)
            // {
            //     Debug.Log("터치 오브젝트 이름 => " + collider2d.name);
            //     // 이동 오브젝트 설정
            //     _moveTr = collider2d.transform;
            // }

			while(transform.position != touchPos)
			{
            	_rigidbody.AddForce(touchPos * 3f);
			}

        }
        else if (_moveTr && Input.GetMouseButtonUp(0))
        {
            // 이동 오브젝트 해제
            _moveTr = null;
            touchPos = transform.position;
        }
        else if (_moveTr)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _moveTr.position = new Vector2(wp.x, wp.y);
            touchPos = new Vector2(wp.x, wp.y);
        }
  
    }
}
