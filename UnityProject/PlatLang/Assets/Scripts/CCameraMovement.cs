using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCameraMovement : MonoBehaviour
{
    float touchFos = 5f;
    Rigidbody2D rigidBody;
    float h, v;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 direction = new Vector2(h, v);
        rigidBody.AddForce(direction * touchFos);
    }

    public void PressKey(int nKey)
    {
        switch (nKey)
        {
            case 1: //left
                h = -1;
                break;
            case 2: //right
                h = 1;
                break;
            case 3: //up
                v = 1;
                break;
            case 4: //down
                v = -1;
                break;
        }
    }

    public void StopMove()
    {
        h = v = 0;
        rigidBody.velocity = Vector2.zero; 
    }

}
