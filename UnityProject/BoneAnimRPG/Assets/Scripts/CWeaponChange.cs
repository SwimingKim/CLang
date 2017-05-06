using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CWeaponChange : MonoBehaviour {

	public GameObject _pick; // 곡갱이
    public GameObject _sword; // 칼

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.X))
		{
            WeaponChange();
        }


	}

	void WeaponChange()
	{
		// GameObject.activeSelf : 현재 오브젝트의 활성/비활성 여부 (true/false)
		// GameObject.SetActive(true/false) : 현재 오브젝트 활성/비활성 설정
        _pick.SetActive(!_pick.activeSelf);
        _sword.SetActive(!_sword.activeSelf);
    }
}
