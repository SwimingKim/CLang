using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI; // AI 사용

public class CMonsterMovement : MonoBehaviour {

	NavMeshAgent _navMeshAgent; // 경로 추적 에이전트 참조

	void Awake()
	{
		_navMeshAgent = GetComponent<NavMeshAgent>();
	}

	void Start()
	{
		Stop();	
	}

	// 몬스터의 이동을 정지함
	public void Stop()
	{
		// 일단 이동을 정지함
		_navMeshAgent.isStopped = true;
	}

	public void Trace()
	{
		// 추적할 대상의 위치를 설정함
		_navMeshAgent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);

		// 대상 위치를 향해 이동을 시작함
		_navMeshAgent.isStopped = false;
	}

}
