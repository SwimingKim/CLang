using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 씬 관리
using UnityEngine.SceneManagement;

public class CShipDamage : MonoBehaviour {

	// 방어막
	public GameObject _shield;

	// OnTriggerEnter2d()
	// - IsTrigger 체크가 되어 있는 오브젝트가 충돌했을 경우 호출되는 이벤트 메소드
	// collision 매개변수는 충돌한 상대 오브젝트의 콜라이더를 의미함
	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(other.name + "오브젝트와 충돌함");

		// Destroy(삭제할게임오브젝트);
		// Destroy(gameObject); // 비행기가 사라짐
		
		if (other.name == "Camera") return;

		// if (other.name == "MidMeteor(Clone)" || other.name == "SmallMeteor(Clone)")
		if (other.tag == "Meteor")
		{
			Destroy(other.gameObject);
			
			// 게임 종료 씬으로 이동
			SceneManager.LoadScene("GameOver");
		}
		else if (other.name == "Shield(Clone)")
		{
			Destroy(other.gameObject);
            Debug.Log("방패 아이템을 먹었음");

            CreateShield();
		}

	}

	void CreateShield()
	{
        Debug.Log(_shield.activeSelf + "입니다");
        // 이미 방패가 있다면
        if (_shield.activeSelf)
		{
            return; // 무시
		}

		// 방패가 없다면 방패를 활성화함
		_shield.SetActive(true);

		// 3초 후에 방패 비활성화 메소드를 실행함
		Invoke("DestroyShield", 3f);
	}

	void DestroyShield()
	{
		//_shield.SetActive(false);
		_shield.gameObject.SetActive(false);
    }

}
