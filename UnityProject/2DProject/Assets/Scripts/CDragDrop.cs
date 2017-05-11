using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDragDrop : MonoBehaviour {

    bool bMouseButtonDown = false;
    Rigidbody2D rigidbody2d;

    void Awake()
	{
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


	void Update()
	{
		/*
		if (Input.GetMouseButtonDown(0))
		{
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 touchPos = new Vector2(wp.x, wp.y);

            Collider2D collider2d = Physics2D.OverlapPoint(touchPos);
			if (collider2d != null)
			{
                bMouseButtonDown = true;
            }
        }
		else if (bMouseButtonDown && Input.GetMouseButtonUp(0))
		{
            bMouseButtonDown = false;
        }
		else if (bMouseButtonDown)
		{
			// 드랍 이벤트
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(wp.x, wp.y);
        }
		*/

		Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition); // 클릭한 위치
		if (Input.GetMouseButtonDown(0))
		{
            Debug.Log("클릭 이벤트");

            rigidbody2d.AddForce(new Vector2(wp.x, wp.y) * 3.4f);
        }
	}

}
