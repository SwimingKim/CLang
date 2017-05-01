using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 자식 - CPinkDamage, CBossDamage
public class CAlienDamage : MonoBehaviour
{

    protected CAlienHealth health;
    Animator animator;

    protected virtual void Start()
    {
        health = GetComponent<CAlienHealth>();
        animator = GetComponent<Animator>();
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bomb")
        {
            CBomb bomb = other.GetComponent<CBomb>();
            if (bomb._canAttack)
            {
                bomb.AttackStateChange();
                // 폭탄에 맞음
                Hit(other);

                if (other.name == "AttackAlien(Cloen)") other.GetComponent<CAttack>().StopAllCoroutines();
            }
        }
    }

    protected virtual void Hit(Collider2D collision)
    {
        animator.SetBool("Bubble", true);

        StartCoroutine("DieCoroutine");
    }

    protected IEnumerator DieCoroutine()
    {
        yield return new WaitForSeconds(5f);

        health.DoDestroy();
    }

    public virtual void ShieldBubble()
    {
        animator.SetBool("Bubble", false);

        StopCoroutine("DieCoroutine");
    }


}
