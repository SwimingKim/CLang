using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyMultiShot : CEnemyShot
{
    public int _multiShotCount; // 멅티 총알 갯수

    // 멀티 총알 발포
    public override void Shot()
    {
        StartCoroutine("MultiShotCoroutine");
    }

    // 코루틴
    // - 시간 지연을 통해 별도의 코드를 비동기적으로 처리함
    IEnumerator MultiShotCoroutine()
    {
        // * 모든 총알의 지연시간이 발포 주기보다는 작아야 함
        for (int i = 0; i < _multiShotCount; i++)
        {
            yield return new WaitForSeconds(0.15f);

            // 총알 발포
            base.Shot();
        }

    }

}
