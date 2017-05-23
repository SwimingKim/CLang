using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSmashStageManager : CStageManager {

	protected override void Awake()
	{
		base.Awake();
		Init(2);
	}
}
