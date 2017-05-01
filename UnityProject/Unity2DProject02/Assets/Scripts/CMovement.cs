using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMovement : MonoBehaviour {

    protected float X_LIMIT_POS = 8.5f;
    protected float Y_LIMIT_POS = 4f;

	public float _speed;

	public void CameraArea()
	{
 		Vector2 pos = transform.position;
		if (Mathf.Abs(pos.x) > X_LIMIT_POS)
		{
            pos.x = Mathf.Sign(pos.x) * X_LIMIT_POS;
        }
		if (Mathf.Abs(pos.y) > Y_LIMIT_POS)
		{
            pos.y = Mathf.Sign(pos.y) * Y_LIMIT_POS;
        }
        transform.position = pos;
	}

}
