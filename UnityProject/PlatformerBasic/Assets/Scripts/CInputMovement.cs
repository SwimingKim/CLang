using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInputMovement : MonoBehaviour {

	// 강체 참조 (이동 및 충돌에 사용)
	[HideInInspector] // 접근지정자는 public이지만 인스펙터쪽에는 노출하지 않음
    public Rigidbody2D _rigidbody2d;

    Animator _animator; // 애니메이션 제어
    SpriteRenderer _spriteRender; // 스프라이트 제어

    public float _speed; // 이동 속도
    public bool _isGround = false; // 지면 위에 있는지 여부

    // 점프 관련 변수
    public bool _isJump = false; // 1단 점프 수행 여부
    public bool _isDoubleJump = false; // 2단 점프 수행 여부

    // Awake() : 게임 오브젝트가 생성될때 호출되는 이벤트 메소드
    // * 중요
    // - Awake 호출 시점에는 계층부에 모든 오브젝트가 생성되어 있다는 보장이 없음
    // - 현재 스크립트 컴포넌트와 같은 계층에 있는 모든 컴포넌트 참조는 가능함
    void Awake()
	{
        _animator = GetComponent<Animator>();
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _spriteRender = GetComponent<SpriteRenderer>();
    }

	// Start() : 게임 오브젝트가 첫번째 렌더링기 바로 전에 호출되는 이벤트 메소드
	// * 중요
	// - Start 호출 시점 계층부에 모든 오브젝트기 생성되어 있음
	// - 이미 생성된 다른 오브젝트의 스크립트 컴포넌트에 있는 모든 컴포넌트 참조는 가능함
	void Start()
	{
		
	}

	void Update()
	{
        InputMove();
        InputJump();
    }

	void InputMove()
	{
        float h = Input.GetAxisRaw("Horizontal");

		// h의 절대값이 양수면
		if (Mathf.Abs(h) > 0)
		{
            // Mathf.Sign(값) : 값이 0보다 크거나 같으면 1을 작으면 -1을 리턴함

            // 입력값에 따라 스프라이트를 반전함
            _spriteRender.flipX = (Mathf.Sign(h) == 1) ? false : true;
        }

        // 캐릭터에 속도를 부여함
        _rigidbody2d.velocity = new Vector2(h * _speed, _rigidbody2d.velocity.y);

        // 이동 애니메이션을 수행함
        _animator.SetFloat("Horizontal", h);

        // 수직 상승 및 하강시 애니메이션을 velocity에 맞게 변환함
        _animator.SetFloat("Vertical", _rigidbody2d.velocity.y);
    }

	void InputJump()
	{
		// 점프키를 눌렀다면
		if (Input.GetKeyDown(KeyCode.Space))
		{
			// 아직 1단 점프를 안했다면
			if (!_isJump)
			{
         	   Jump(); // 점프 수행

                _isJump = true; // 1단 점프 수행 함
            }

			// 1단 점프는 했지만 2단 점프는 안했다면
			else if (_isJump && !_isDoubleJump)
			{
                Jump(); // 점프 수행

                _isDoubleJump = true; // 2단 점프 수행 함
            }
        }
	}

	void Jump()
	{
		// 점프 애니메이션 수행
        _animator.SetTrigger("Jump");

        // 점프를 위해 이전 수직 및 하강 속도를 초기화 함
        _rigidbody2d.velocity = new Vector2(_rigidbody2d.velocity.x, 0f);

        // 점프 수행
        _rigidbody2d.AddForce(Vector2.up * 1300f);
    }


    void OnCollisionEnter2D(Collision2D other)
	{
		// 지면 충돌이 시작될때 처리
		if (other.gameObject.tag == "Ground")
		{
            _isGround = true;

            // 애니메이션에 IsGround값을 넘겨줌
            _animator.SetBool("IsGround", _isGround);

            _isJump = _isDoubleJump = false; // 점프 전 상태로 값 변경
        }
		
	}

	void OnCollisionExit2D(Collision2D other)
	{
		// 지면 충돌이 끝났을때 처리
		if (other.gameObject.tag == "Ground")
		{
            _isGround = false;

            // 애니메이션에 IsGround값을 넘겨줌
            _animator.SetBool("IsGround", _isGround);
        }
		
	}





}
