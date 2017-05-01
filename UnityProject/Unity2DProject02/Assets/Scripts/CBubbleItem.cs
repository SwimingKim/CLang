using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBubbleItem : CItem {

	protected override void OnTriggerEnter2D(Collider2D other)
	{
        base.OnTriggerEnter2D(other);
        if (other.name == "Hero")
		{
            other.GetComponent<CHeroAttack>()._bombMax++;

            Destroy(gameObject);
        }
		
	}

}
