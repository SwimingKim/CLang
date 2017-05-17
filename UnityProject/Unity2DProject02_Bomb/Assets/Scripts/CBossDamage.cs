using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 보스 데미지
public class CBossDamage : CAlienDamage {

	public int _power;

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.tag == "Bubble")
        {
            CBubleTimer timer = other.GetComponent<CBubleTimer>();
			if (!timer.hasBombs) timer.MakeBomb();
        }

    }

	protected override void Hit(Collider2D collision)
	{
        // hp 감소
        int hp = (health as CBossHealth).HpDown(_power);
		if (hp <= 0)
		{
            (health as CBossHealth).DoDestroy();
        }
    }

}
