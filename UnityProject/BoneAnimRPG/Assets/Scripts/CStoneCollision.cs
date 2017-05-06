using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// public class CStoneCollision : CCollision { // abstract Collision 클래스 상속
// public class CStoneCollision : MoneBehaviour, ICollision
public class CStoneCollision : MonoBehaviour
{
    public int _score;

    public void Hit(bool isNotPick)
	{
        Debug.Log("stone collision");

		if (isNotPick) return;

        // 게임 매니저에게 점수 증가를 요청함
        GameObject.Find("GameManager").SendMessage("ScoreUp", _score);

        Destroy(gameObject);
    }

	/*
	public override void Hit(bool isNotPick) // abstract Collision 클래스 상속
	{
        Debug.Log("stone collision");
		if (isNotPick) return;
        Destroy(gameObject);
    }
	*/

}
