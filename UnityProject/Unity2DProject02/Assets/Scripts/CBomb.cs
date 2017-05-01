using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBomb : MonoBehaviour {

    public bool _canAttack = true;

	public void AttackStateChange()
	{
        _canAttack = !_canAttack;
    }

}
