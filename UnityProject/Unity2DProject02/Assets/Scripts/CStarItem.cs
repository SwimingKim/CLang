using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CStarItem : CItem {

	protected override void OnTriggerEnter2D(Collider2D other)
	{
        base.OnTriggerEnter2D(other);
        if (other.name == "Hero")
		{
            GameObject starCount = GameObject.Find("StarCountText");

            Text countText = starCount.GetComponent<Text>();
            int count = int.Parse(countText.text);
            count += 1;

            countText.text = count.ToString();
            Destroy(gameObject);
        }
	}

}
