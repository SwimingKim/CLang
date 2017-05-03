using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 주인공 데미지
public class CHeroDamage : CAlienDamage {

    public bool hasShield = false;
    CGameManager gameManager;

    protected override void Start()
    {
        base.Start();
        gameManager = GameObject.Find("GameManager").GetComponent<CGameManager>();
    }

    protected override void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (other.gameObject.GetComponent<Animator>().GetBool("Bubble"))
            {
                // 버블상태에서 히어로와 충돌한 경우 count up
                Text starCount = GameObject.Find("StarCountText").GetComponent<Text>();
                int count = int.Parse(starCount.text);
                starCount.text = (++count).ToString();

                CAlienHealth otherHealth = other.gameObject.GetComponent<CAlienHealth>();
                otherHealth.SendMessage("DoDestroy");

                // 업캐스팅
                // if (otherHealth is CBossHealth) (otherHealth as CBossHealth).DoDestroy();
                // else if (otherHealth is CItemAlienHealth) (otherHealth as CItemAlienHealth).DoDestroy();
                // else otherHealth.DoDestroy();
            }
            else
            {
                (health as CHeroHealth).DoDestroy();
                // health.SendMessage("DoDestroy");
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
