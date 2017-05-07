using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class CZombieCollision : CCollision {
// public class CZombieCollision : MonoBehaviour, ICollision {
public class CZombieCollision : MonoBehaviour {

	// 모든 본 부위의 스프라이트 렌더러를 참조
    SpriteRenderer[] _spriteRenderers;

    CZombieMovement _zombieMovement;

    // Use this for initialization
    void Start () {
        _spriteRenderers = GetComponentsInChildren<SpriteRenderer>();
        _zombieMovement = GetComponent<CZombieMovement>();
    }

	public void Hit(bool isSword)
	{
        Debug.Log("zombie collision");

        // 좀비를 피격한 무기가 칼이 아닐 경우
        if (!isSword) return;

        // 피격 효과를 수행함
        StartCoroutine("HitAnimCoroutine");

        _zombieMovement.Flip(); // 방향을 전환함
        _zombieMovement.SpeedUp(2.5f); // 2.5배 속도로 이동 속도를 증가 시킴
    }

    /*
    public override void Hit(bool isSword)
    {
        Debug.Log("zombie collision");

        // 좀비를 피격한 무기가 칼이 아닐 경우
        if (!isSword) return;

        // 피격 효과를 수행함
        StartCoroutine("HitAnimCoroutine");

        _zombieMovement.Flip(); // 방향을 전환함
        _zombieMovement.SpeedUp(2.5f); // 2.5배 속도로 이동 속도를 증가 시킴

    }
    */

	// 피격 색상 변경 지연 처리
	IEnumerator HitAnimCoroutine()
	{
        // Color color = new Color(R, G, B, A);
        // SetColor(Color.red); // 붉은색 피격 효과를 설정함
        SetColor(new Color(1f, 0f, 0f)); // 붉은색 피격 효과를 설정함 (1 => 255)

        yield return new WaitForSeconds(0.1f); // 0.1초 지연함
        
		SetColor(Color.white); // 원래 색상으로 설정함
    }

	// 색상 변경
	void SetColor(Color color)
	{
		// 본 스프라이트들의 색상을 지정한 색상으로 변경함
		foreach (SpriteRenderer sr in _spriteRenderers)
		{
            sr.color = color;
        }
	}



}
