using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBackground : MonoBehaviour {

	void Start()
	{
        // 현재 오브젝트는 씬이 전환되도 삭제되지 않음
        DontDestroyOnLoad(gameObject);
    }

}
