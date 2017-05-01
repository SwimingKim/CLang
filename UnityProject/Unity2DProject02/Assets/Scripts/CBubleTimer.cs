using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBubleTimer : MonoBehaviour {

    public GameObject _bombPrefab;
    public Transform[] _createPos;

    public float _bombDelayTime; // 폭탄 생성 시간
    public float _bombRemoveTime; // 폭탄 제거 시간

    CGameManager gameManager;
    
    int[] _stateNum = { 5, 9, 13 }; // 해당 버블에 달린 폭탄의 개수 

    GameObject[] bombs;
    public bool hasBombs = false;

    void Start () {
        StartCoroutine("BombCoroutine");

        gameManager = GameObject.Find("GameManager").GetComponent<CGameManager>();
    }

    public void MakeBomb()
    {
        hasBombs = true;
        int bombNum = (gameObject.tag == "Bubble") ? _stateNum[gameManager._bombState] : 5;

        bombs = new GameObject[bombNum];
        for (int i = 0; i < bombNum; i++)
		{
			bombs[i] = Instantiate(_bombPrefab, _createPos[i].position, Quaternion.identity);
            bombs[i].transform.SetParent(_createPos[i]);
        }

        Invoke("RemoveBomb", _bombRemoveTime);
    }

    void RemoveBomb()
    {
        Destroy(gameObject); // 버블(부모)가 삭제되면서 자식(폭탄)도 같이 삭제
    }

    IEnumerator BombCoroutine()
    {
        yield return new WaitForSeconds(_bombDelayTime);
        if(!hasBombs) MakeBomb();
    }

}
