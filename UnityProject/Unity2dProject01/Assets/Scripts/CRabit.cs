using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRabit : MonoBehaviour {

    public CGameManager _gameManager;
    public Rigidbody2D _rigidbody;
    public float _jumpSpeed;

    float X_LIMIT_POS = 9.6f;
    float Y_LIMIT_POS = 6.5f;

    public GameObject _shotPrefab;
    public Transform _shotPos;

    public float _jumpDelayTime, _shotDelayTime;
    float jumpTimer, shotTimer;

    void Start()
	{
        // 시작하자마자 게임이 종료되는 것 방지
        _rigidbody.velocity = Vector2.zero;
    }

	void Update () {
        // 점프 타이머
        jumpTimer += Time.deltaTime;

		if (Input.GetKeyDown(KeyCode.Space) && jumpTimer >= _jumpDelayTime)
		{
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * _jumpSpeed);
            jumpTimer = 0f;
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

        // 공격 타이머
        shotTimer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.LeftControl) && shotTimer >= _shotDelayTime)
        {
            Instantiate(_shotPrefab, _shotPos.position, Quaternion.identity);
            shotTimer = 0f;
        }

    }

	void OnTriggerEnter2D(Collider2D other)
	{
        if(other.tag == "Spring")
		{
			_rigidbody.AddForce(Vector2.up * _jumpSpeed * 4f); // 4배 점프 증가
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

    // 땅을 걸어다니는 경우 애니메이션 변화
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            GetComponent<Animator>().Play("BrownRun", 0);
        }
    }






}
