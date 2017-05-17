using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHeroHealth : CAlienHealth {

	public override void DoDestroy()
	{
        base.DoDestroy();

        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
		foreach (GameObject item in boxes)
		{
            item.GetComponent<CBoxCollision>().RemoveBox();
        }

    }

}
