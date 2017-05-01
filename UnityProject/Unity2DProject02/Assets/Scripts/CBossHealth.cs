using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CBossHealth : CAlienHealth {

    public Image _healthProgress;
    public int _hp; // 체력 수치

    public GameObject _starPrefab;

    public int HpDown(float damage)
	{
        _healthProgress.fillAmount -= (damage * 0.01f);

        _hp -= (int)damage;

        return _hp;
    }

    // 보스 죽음
	public override void DoDestroy()
	{
        Debug.Log("보스 죽음");
        base.DoDestroy();

        GameObject[] bubbles = GameObject.FindGameObjectsWithTag("Bubble");
		foreach (GameObject item in bubbles)
		{
            Destroy(item.gameObject);
        }

        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject item in enemys)
        {
            Destroy(item);
        }

        GameObject[] titles = GameObject.FindGameObjectsWithTag("Tile");
        int coinNum = Random.Range(10, 20);
        for (int i = 0; i < coinNum; i++)
        {
            Instantiate(_starPrefab, titles[i].transform.position, Quaternion.identity);
        }

    }

    

}
