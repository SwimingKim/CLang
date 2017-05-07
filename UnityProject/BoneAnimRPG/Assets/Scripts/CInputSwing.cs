using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInputSwing : MonoBehaviour
{

    public Animator _animator;

    public Transform _attackPoint;
    public LayerMask _attackTargetMask; // 충돌 대상 레이어 마스크

    public CWeaponChange _weaponChange; // 무기 변경

    // Use this for initialization
    void Start()
    {
        string[] maskName = { "Zombie", "Stone" };
        _attackTargetMask = LayerMask.GetMask(maskName);

    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo animState = _animator.GetCurrentAnimatorStateInfo(0);
        /*
        // 현재 실행 중인 애니메이션이 스윙이 맞으면 패쓰
		if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Swing"))
		{
            return;
        }
		*/

        // 현재 z키를 누른게 맞다면
        if (Input.GetKeyDown(KeyCode.Z) && !animState.IsName("Swing") && !animState.IsName("Die"))
        {
            // 스윙 애니메이션을 실행하라
            _animator.SetTrigger("Swing");
        }

    }

    // 스윙 공격(타격) 애니메이션 이벤트
    public void SwingAttackEvent()
    {
        // Debug.Log("스윙 공격 애니메이션 이벤트 메소드 호출!!!");

        // Collider2D 충돌대상 = Physics2D.OverlapCircle(오버랩충돌체크위치, 검출범위, 검출대상레이어);
        // 지정한 공격 타겟 레이어를 가진 오브젝트와 공격 포인트를 기준으로 충돌되었는지를 검출함
        Collider2D hitCollision = Physics2D.OverlapCircle(_attackPoint.position, 0.4f, _attackTargetMask);

        // 충돌되는 오브젝트가 없음
        if (hitCollision == null) return;

        /*
        if (hitCollision.tag == "Zombie")
        {
            // Debug.Log("스윙 공격에 의해 충돌된 오브젝트가 발생함!!!");
            // 피격된 좀비의 피격 처리 컴포넌트를 추출함
            // CZombieCollision zombieCol = hitCollision.GetComponent<CZombieCollision>();
            // zombieCol.Hit(); // 좀비에게 피격을 요청함
            // hitCollision.GetComponent<CZombieCollision>().Hit();
            
            // 피격된 좀비의 피격 처리 컴포넌트를 추출함
            CZombieCollision zombieCol = hitCollision.GetComponent<CZombieCollision>();
            zombieCol.Hit(_weaponChange._sword.activeSelf); // 좀비에게 피격을 요청함
        }
        else if (hitCollision.tag == "Stone")
        {
            // 피격된 운석의 피격 처리 컴포넌트를 추출함
            CStoneCollision stoneCol = hitCollision.GetComponent<CStoneCollision>();
            stoneCol.Hit(_weaponChange._sword.activeSelf);
        }
        */

        // 개선1
        // 업캐스팅 수행 (CZombieCollision -> CCollision, CStoneCollision -> CCollision)
        // 업캐스팅을 통한 다형성 수행
        // CCollision collision = hitCollision.GetComponent<CCollision>();

        // 개선2 : 인터페이스를 통한 다형성
        // ICollision collision = hitCollision.GetComponent<ICollision>();
        // collision.Hit(_weaponChange._sword_.activeSelf);

        // 개선3
        hitCollision.SendMessage("Hit", _weaponChange._sword.activeSelf);

    }

}
