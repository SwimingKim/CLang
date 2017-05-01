using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShieldItem : CItem {

	protected override void OnTriggerEnter2D(Collider2D other)
	{
        base.OnTriggerEnter2D(other);
        if (other.name == "Hero")
		{
            Animator animator = other.GetComponent<Animator>();
            if (animator.GetBool("Bubble")) 
			{
                other.GetComponent<CHeroDamage>().ShieldBubble();
            }
			else
			{
                other.GetComponent<CHeroDamage>().hasShield = true;
            }

            Destroy(gameObject);
        }
	}

}
