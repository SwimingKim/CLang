using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMovement : MonoBehaviour
{

    int _layerMask;
    UnityEngine.AI.NavMeshAgent _navMeshAgent;

    Animator _animator;
    Vector3 _moveTargetPos; // 이동 위치
    GameObject _actionTarget; // 공격 대상

    // 기사 상태 설정
    public enum STATE
    {
        IDLE, MOVE, ATTACK_MOVE, ATTACK
    };
    public STATE _state = STATE.IDLE;

    void Awake()
    {
        _moveTargetPos = Vector3.zero;
        _navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    void Start()
    {
        _navMeshAgent.Stop();
        // 사용할 충돌 레이어 마스크 정보를 설정
        _layerMask = LayerMask.GetMask("Ground", "Monster", "Object");

    }

    void Update()
    {
        MoveAction();
    }

    void MoveAction()
    {
        // 화면을 터치했다면
        if (Input.GetMouseButtonDown(0))
        {
            // 터치한 화면 위치로 레이 객체를 생성함
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; // 충돌 정보

            STATE moveState = STATE.MOVE;
            if (Physics.Raycast(ray, out hit, 100f, _layerMask))
            {
                int layer = hit.transform.gameObject.layer;

                // 건물이나 물체를 터치했다면
                if (layer == LayerMask.NameToLayer("Object"))
                {
                    return;
                }

                // 터치한 바닥의 위치를 이동 위치로 설정함
                _moveTargetPos = hit.point;

                if (layer == LayerMask.NameToLayer("Ground"))
                {
                    moveState = STATE.MOVE;
                }
                else if (layer == LayerMask.NameToLayer("Monster"))
                {
                    // 터치한 공격 대상 오브젝트를 설정
                    _actionTarget = hit.transform.gameObject;

                    // 이동을 하긴 하는데 공격을 위한 이동을 함
                    moveState = STATE.ATTACK_MOVE;
                }

                // 기사 이동
                Move(moveState);

            }
        }
        else
        {
            float dist = 0f;

            if (_actionTarget != null)
            {
                dist = Vector3.Distance(_actionTarget.transform.position, transform.position);
                _moveTargetPos = _actionTarget.transform.position;
            }
            else
            {
                // 최종 이동 목적지와의 거리를 측정
                dist = Vector3.Distance(_moveTargetPos, transform.position);
            }

            // 단순 이동이 목표이고 거리가 0.25안에 들어왔다면
            if (_state == STATE.MOVE && dist <= 0.25f)
            {
                // 네비게이션 이동 중지
                _navMeshAgent.Stop();

                // 이동 위치 강제 지정
                // transform.position = _moveTargetPos;

                // 대기 애니메이션 실행
                PlayAnimation(STATE.IDLE);
            }
            // 공격을 위해 이동 중에 공격 사정거리 안으로 들어오면
            else if (_state == STATE.MOVE && dist <= 2f)
            {
                _navMeshAgent.Stop();
                transform.LookAt(_actionTarget.transform);
                PlayAnimation(STATE.ATTACK);
            }
            // 공격을 하거나 하기 위해 이동중인데 거리가 2미터 이상 다시 벌어지면
            else if ((_state == STATE.ATTACK_MOVE || _state == STATE.ATTACK) && dist > 2f)
            {
                _navMeshAgent.SetDestination(_actionTarget.transform.position);
                Debug.Log("다시 추적해라");

                _navMeshAgent.Resume();
                PlayAnimation(STATE.ATTACK_MOVE);
            }

        }
    }

    // 이동
    void Move(STATE moveState)
    {
        // 일단 이전에 이동하고 있던 중일 수도 있으므로
        // 이동을 중단함
        _navMeshAgent.Stop();

        // 터치한 위치로 네비게이션의 이동 위치를 수정함
        _navMeshAgent.SetDestination(_moveTargetPos);

        // 이동
        _navMeshAgent.Resume();

        // 이동 애니메이션 실행
        PlayAnimation(moveState);
    }

    // 애니메이션 실행
    void PlayAnimation(STATE state)
    {
        // 모든 애니메이션 상태를 초기화함
        _animator.SetBool("Walk", false);
        _animator.SetBool("Attack", false);

        _state = state; // 상태를 변경함
        switch (_state)
        {
			case STATE.MOVE :
			case STATE.ATTACK_MOVE :
                _animator.SetBool("Walk", true);
                break;
			case STATE.IDLE :
                _animator.SetBool("Walk", false);
                break;
			case STATE.ATTACK :
                _animator.SetBool("Attack", true);
                break;
        }

    }



}
