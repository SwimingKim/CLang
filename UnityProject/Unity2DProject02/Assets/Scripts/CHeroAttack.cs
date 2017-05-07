using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHeroAttack : CAttack
{
	Animator animator;
    CHeroDamage damage;

    void Start()
    {
        animator = GetComponent<Animator>();
        damage = GetComponent<CHeroDamage>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!animator.GetBool("Bubble"))
            {
                bool isBubble = MakeBubble();
                if (isBubble) animator.SetTrigger("Attack");
            }
			else if (damage.hasShield)
            {
                damage.ShieldBubble();
            }
        }
    }


}
