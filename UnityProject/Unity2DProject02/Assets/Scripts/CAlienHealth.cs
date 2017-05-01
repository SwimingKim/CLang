using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CAlienHealth : MonoBehaviour
{

    public CGameManager _gameManager;

    public GameObject _dieEffectPrefab;

    public virtual void DoDestroy()
    {
        Destroy(gameObject);
        ShowDieEffect(transform.position);

        if (_gameManager == null) // 일반적인 적의 죽음
        {
            GameObject starCount = GameObject.Find("StarCountText");

            Text countText = starCount.GetComponent<Text>();
            int count = int.Parse(countText.text);
            count += 1;

            countText.text = count.ToString();
            Destroy(gameObject);
        }
        else // 히어로나 보스의 죽음
        {
            _gameManager._endWaitTime = gameObject.name == "Hero" ? 1.5f : 7f;

            _gameManager.StartCoroutine("GameEnd");
        }

    }

    public void ShowDieEffect(Vector2 pos)
    {
        if (_dieEffectPrefab != null)
        {
            GameObject effect = Instantiate(_dieEffectPrefab, pos, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
    }



}
