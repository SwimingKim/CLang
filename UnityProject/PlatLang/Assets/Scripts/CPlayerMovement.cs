using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerMovement : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Gnome");
    }

	void Update()
	{
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(h, v);

        transform.Translate(direction * 3f * Time.deltaTime);
	}

    void OnApplicationQuit()
    {
        transform.Translate(Vector2.zero);
    }

}