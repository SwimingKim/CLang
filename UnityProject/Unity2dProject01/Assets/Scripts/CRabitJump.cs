using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRabitJump : MonoBehaviour {

    public CGameManager _gameManager;
    public Rigidbody2D _rigidbody;
    public float _speed;

    float X_LIMIT_POS = 9.6f;
    float Y_LIMIT_POS = 6.5f;


    void Start()
	{
        _rigidbody.velocity = Vector2.zero;
    }

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * _speed);
        }

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(h, v);
        transform.Translate(direction * 3f * Time.deltaTime);

        Vector2 pos = transform.position;
        if (pos.x < -X_LIMIT_POS || pos.x > X_LIMIT_POS || pos.y < -Y_LIMIT_POS || pos.y > Y_LIMIT_POS)
        {
            if (_gameManager._bubble.activeSelf)
            {
                _gameManager.DestroyBubble();
                _rigidbody.velocity = Vector2.zero;
                _rigidbody.position = Vector2.zero;
            }
            else 
            {
                _gameManager.GameEnd();
            }
        }


    }

	void OnTriggerEnter2D(Collider2D other)
	{
        // Debug.Log(other.name);
        if(other.name == "SmallSpring")
		{
			_rigidbody.AddForce(Vector2.up * _speed * 2f);
		}
        else if (other.tag == "Carrot")
        {
            Destroy(other.gameObject);
            _gameManager.GetCarrot();
        }
	}

	void OnCollisionEnter2D(Collision2D other)
	{
        if (other.gameObject.tag == "Enemy")
		{
            if (_gameManager._bubble.activeSelf)
            {
                Destroy(other.gameObject);
                _gameManager.DestroyBubble();
            }
            else
            {
                _gameManager.GameEnd();
            }
        }
        else if (other.gameObject.tag == "Bubble")
        {
            Destroy(other.gameObject);
            _gameManager.CreateBubble();
        }
    }




}
