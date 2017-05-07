using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyShot : CShot {

    // Use this for initialization
    protected override void Start () {
        
        base.Start();

        InvokeRepeating("Shot", _shotDelayTime, _shotDelayTime);
    }

}
