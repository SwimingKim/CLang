using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInputMovement : CMovement {

    public bool _isRightFace = true;

	void Update () {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(h, v);

        if ((h>0 && !_isRightFace) || (h<0 && _isRightFace))
		{
            Flip();
        }

        CameraArea();

        transform.Translate(direction * _speed * Time.deltaTime);
    }

	void Flip()
	{
        Vector3 scale = transform.localScale;

        scale.x *= -1;
        transform.localScale = scale;

        _isRightFace = !_isRightFace;
    }


}
