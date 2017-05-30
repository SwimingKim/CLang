using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPlayerMovement : MonoBehaviour
{
    public float _speed;
    float _touchFos = 5f;
    float h, v;

    bool isJump;

    Rigidbody2D _rigidbody2d;
    Animator _animator;
    public SpriteRenderer[] _spriteRender;

    void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {   
        // 에디터 상에서 확인
        if (Input.GetKeyDown(KeyCode.A)) PressKey(1);
        else if (Input.GetKeyDown(KeyCode.S)) PressKey(2);
        else if (Input.GetKeyDown(KeyCode.D)) PressKey(3);
        else if (Input.GetKeyDown(KeyCode.F)) PressKey(4);
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) 
        || Input.GetKeyDown(KeyCode.D) || Input.GetKeyUp(KeyCode.F)) StopMove();

        InputMove();
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
                // v = 1;
                InputJump();
                break;
            case 4: //down
                v = -1;
                break;
        }
    }

    public void InputJump()
    {
        if (!isJump)
        {
            _animator.SetTrigger("Jump");
            _rigidbody2d.velocity = new Vector2(_rigidbody2d.velocity.x, 0f);
            _rigidbody2d.AddForce(Vector2.up * 1300f);

            isJump = true;
        }
    }

    public void InputMove()
    {
        if (Mathf.Abs(h) > 0)
        {
            for (int i = 0; i < _spriteRender.Length; i++)
            {
                _spriteRender[i].flipX = (Mathf.Sign(h) == 1) ? true : false;
            }
        }

        _rigidbody2d.velocity = new Vector2(h * _speed, _rigidbody2d.velocity.y);

        _animator.SetFloat("Horizontal", h);
        _animator.SetFloat("Vertical", _rigidbody2d.velocity.y);
    }

    public void StopMove()
    {
        h = v = 0;
        _rigidbody2d.velocity = Vector2.zero;
    }

    void OnApplicationQuit()
    {
        transform.Translate(Vector2.zero);
    }

}