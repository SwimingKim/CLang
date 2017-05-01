using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 주인공 데미지
public class CHeroDamage : CAlienDamage {

    public bool hasShield = false;
    CGameManager gameManager;

    protected override void Start()
    {
        base.Start();
        gameManager = GameObject.Find("GameManager").GetComponent<CGameManager>();
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);

        if (other.tag == "Enemy")
        {
            if (other.GetComponent<Animator>().GetBool("Bubble"))
            {
                CAlienHealth health = other.GetComponent<CAlienHealth>();
                // if (health is CBossHealth) (health as CBossHealth).DoDestroy();
                // else if (health is CItemAlienHealth) (health as CItemAlienHealth).DoDestroy();
                // else health.DoDestroy();
                health.SendMessage("DoDestroy");
            }
            else
            {
                health.DoDestroy();
            }
        }
    }

    protected override void Hit(Collider2D collision)
	{
        base.Hit(collision);

        if (hasShield) 
        {
            gameManager.ShieldBar.enabled = true;
            gameManager.ShieldText.enabled = true;
        }
    }

    public override void ShieldBubble()
    {
        base.ShieldBubble();

        if (hasShield)
        {
            hasShield = !hasShield;
            gameManager.ShieldBar.enabled = false;
            gameManager.ShieldText.enabled = false;
        }
    }

}
