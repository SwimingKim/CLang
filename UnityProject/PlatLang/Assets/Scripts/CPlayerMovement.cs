using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerMovement : MonoBehaviour
{
    float _touchFos = 5f;
    Rigidbody2D _rigidBody;
    float h, v;

    public bool _main;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
#elif UNITY_ANDROID || UNITY_IOS
        Debug.Log("모바일입니다");
#endif

        Vector2 direction = new Vector2(h, v);

        transform.Translate(direction * 3f * Time.deltaTime);
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
        _rigidBody.velocity = Vector2.zero;
    }

    void OnApplicationQuit()
    {
        transform.Translate(Vector2.zero);
    }

}