using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBubleTimer : MonoBehaviour {

    public GameObject _bombPrefab;
    public Transform[] _createPos;

    public float _bombDelayTime; // 폭탄 생성 시간
    public float _bombRemoveTime; // 폭탄 제거 시간


    GameObject[] bombs;
    public bool hasBombs = false;

    public virtual void Start () {
        StartCoroutine("BombCoroutine");
    }

    public virtual void MakeBomb()
    {
        hasBombs = true;
        int bombNum = _createPos.Length;

        bombs = new GameObject[bombNum];
        for (int i = 0; i < bombNum; i++)
		{
            // 박스가 있는지 확인
            bombs[i] = Instantiate(_bombPrefab, _createPos[i].position, Quaternion.identity);
            bombs[i].transform.SetParent(_createPos[i]);
        }

        Invoke("RemoveBomb", _bombRemoveTime);
    }

    protected void RemoveBomb()
    {
        Destroy(gameObject); // 버블(부모)가 삭제되면서 자식(폭탄)도 같이 삭제
    }

    IEnumerator BombCoroutine()
    {
        CheckBox();

        yield return new WaitForSeconds(_bombDelayTime);
        if(!hasBombs) MakeBomb();
    }

    protected virtual void CheckBox()
    {
    }

}
