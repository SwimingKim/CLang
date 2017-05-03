using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAlienDamage : MonoBehaviour
{

    protected CAlienHealth health;
    Animator animator;

    protected virtual void Start()
    {
        health = GetComponent<CAlienHealth>();
        animator = GetComponent<Animator>();
    }

    // 폭탄이 터지면 버블로 만들기
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

    protected virtual void OnCollisionEnter2D(Collision2D other)
    {
    }

    protected virtual void Hit(Collider2D collision)
    {
        animator.SetBool("Bubble", true);

        StartCoroutine("DieCoroutine");
    }

    protected IEnumerator DieCoroutine()
    {
        yield return new WaitForSeconds(5f);

        health.SendMessage("DoDestroy"); // 업캐스팅
    }

    public virtual void ShieldBubble()
    {
        animator.SetBool("Bubble", false);

        StopCoroutine("DieCoroutine");
    }


}
