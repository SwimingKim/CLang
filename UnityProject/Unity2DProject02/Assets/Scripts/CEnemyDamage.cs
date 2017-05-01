using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyDamage : CAlienDamage
{

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.tag == "Enemy" && !other.GetComponent<Animator>().GetBool("Bubble") && GetComponent<Animator>().GetBool("Bubble"))
        {
            Debug.Log("동료가 구해줌");
            ShieldBubble();

            if (other.name == "AttackAlien(Cloen)") other.GetComponent<CAttack>().StopAllCoroutines();
        }
    }

}
