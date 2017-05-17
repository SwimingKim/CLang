using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPowerItem : CItem {

    CGameManager gameManager;

    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<CGameManager>();
    }

	protected override void OnTriggerEnter2D(Collider2D other)
	{
        base.OnTriggerEnter2D(other);

        if (other.name == "Hero")
		{
            CGameManager._bombState++;
            Destroy(gameObject);
        }
		if (other.tag == "Bomb")
		{
            Destroy(gameObject);
        }
    }

}
