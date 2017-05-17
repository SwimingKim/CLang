using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBomb : MonoBehaviour {

    public bool _canAttack = true;

	public void AttackStateChange()
	{
        _canAttack = !_canAttack;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gameObject.name + " : " + other.name);

        CBoxCollision box = other.GetComponent<CBoxCollision>();
        if (box!=null && box.isCollision)
        {
            box.isCollision = false;
            box.RemoveBox();
        }
    }

}
