using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAlienHealth : MonoBehaviour
{
    public CGameManager _gameManager;

    public GameObject _dieEffectPrefab;
    public GameObject _saveEffectPrefab;

    public virtual void DoDestroy()
    {
        Destroy(gameObject);
        ShowDieEffect(transform.position);

        if (_gameManager == null) // 일반적인 적의 죽음
        {
            Destroy(gameObject);
        }
        else // 히어로나 보스의 죽음
        {
            GameObject[] bubbles = GameObject.FindGameObjectsWithTag("Bubble");
            foreach (GameObject item in bubbles)
            {
                Destroy(item.gameObject);
            }

            GameObject[] enemyBubbles = GameObject.FindGameObjectsWithTag("EnemyBubble");
            foreach (GameObject item in enemyBubbles)
            {
                Destroy(item.gameObject);
            }

            GameObject[] bombs = GameObject.FindGameObjectsWithTag("Bomb");
            foreach (GameObject item in bombs)
            {
                Destroy(item.gameObject);
            }

            GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
            foreach (GameObject item in boxes)
            {
                item.GetComponent<CBoxCollision>().RemoveBox();
            }

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

    public void ShowSaveEffect(Vector2 pos)
    {
        if (_saveEffectPrefab != null)
        {
            GameObject effect = Instantiate(_saveEffectPrefab, pos, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
    }



}
