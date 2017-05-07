using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyDamage : CAlienDamage
{

    protected override void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy" && !other.gameObject.GetComponent<Animator>().GetBool("Bubble") && GetComponent<Animator>().GetBool("Bubble"))
        {
            Debug.Log("동료가 구해줌");

            // 구해주는 효과
            gameObject.GetComponent<CAlienHealth>().ShowSaveEffect(transform.position);

            ShieldBubble();

            if (other.gameObject.name == "AttackAlien(Cloen)") other.gameObject.GetComponent<CAttack>().StartCoroutine("MakeBubbleCoroutine");
        }
    }

}
