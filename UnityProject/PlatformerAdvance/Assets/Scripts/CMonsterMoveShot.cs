using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonsterMoveShot : CMonsterMoveAttack {

	public GameObject _bulletPrefab;

	public override void Attack()
	{
        Debug.Log("Shot Attack");

        // 총알 발사
        GameObject bullet = Instantiate(_bulletPrefab, _attackPoint.position, Quaternion.identity) as GameObject;
        bullet.SendMessage("Init", _monsterState._isRightDir);
    }

}
