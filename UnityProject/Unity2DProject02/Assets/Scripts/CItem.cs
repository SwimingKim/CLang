using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItem : MonoBehaviour {

	protected virtual void OnTriggerEnter2D(Collider2D other)
	{
        Debug.Log(other.tag);
        if (other.tag == "Bomb")
		{
            Destroy(gameObject);
        }
	}

}
