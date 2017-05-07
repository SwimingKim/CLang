using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlane : MonoBehaviour {

    public Rigidbody2D _rigidbody2d;

    public float _riseForce; // 점프 힘

    public CGameManager _gameManager; // 게임 매니저

    // Use this for initialization
    void Start()
    {
        // 속도의 예
        // _rigidbody2d.velocity = Vector2.right * 3f;

        // Transform.Translate의 예
        // transform.Translate(Vector2.right * 3f);

    }

    // Update is called once per frame
    void Update () {

        if (transform.position.y > 5.5f)
        {
            CGameManager.isGameStop = true;
        }

        if (transform.position.y < -5.5f)
        {
            CGameManager.isGameStop = true;

            // 게임 종료 처리
            _gameManager.GameEnd();
        }

        // 아무키나 눌렀다면
        if (Input.anyKeyDown && !CGameManager.isGameStop)
        {
            // 비행기의 수직 하강 속도를 0으로 설정함
            // Rigidbody2d.velocity : 속도
            // Vector2.zero : (0, 0) 벡터
            _rigidbody2d.velocity = Vector2.zero;


            // 점프
            // Rigidbody2d.AddForce(방향 * 힘);
            _rigidbody2d.AddForce(Vector2.up * _riseForce);
            // _rigidbody2d.AddForce(new Vector2(0f, _riseForce));
        }

    }



    // IsTrigger가 체크 되지 않은 오브젝트끼리 충돌
    void OnCollisionEnter2D(Collision2D other)
    {
        // 현재 비행기가 컬럼이랑 충돌한거라면
        if (other.gameObject.tag == "Column")
        {
            // 게임 정지 설정
            CGameManager.isGameStop = true;

            // 3초 뒤에 게임을 종료함
            Invoke("GameEndTimer", 3f);
        }        
    }

    public void GameEndTimer()
    {
        _gameManager.GameEnd();
    }

    // IsTrigger가 체크 되어 있는 오브젝트와 충돌
    void OnTriggerEnter2D(Collider2D other)
    {
        // 비행기가 먹은 게 별아이템이면
        if (other.gameObject.tag == "StarItem")
        {
            // 별접 점수를 증가함
            _gameManager.ScoreUp();

            // 별 아이템을 파괴함
            Destroy(other.gameObject);
        }
        
    }

}
