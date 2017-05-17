using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHeroBubbleTimer : CBubleTimer
{
    public LayerMask _boxMask;

    int[] bombRange = { 0, 0, 0, 0 }; // 좌우상하
    Vector2[] multiVec = { new Vector2(-1.28f, 0), new Vector2(1.28f, 0), new Vector2(0, 1.28f), new Vector2(0, -1.28f) };

    public override void MakeBomb()
    {
        hasBombs = true;

        // 중앙
        GameObject center = Instantiate(_bombPrefab, transform.position, Quaternion.identity);
        center.transform.SetParent(transform);

        // 상하좌우
        for (int i = 0; i < bombRange.Length; i++)
        {
            Vector2 vec = multiVec[i];

            for (int j = 1; j < bombRange[i]; j++)
            {
                Vector2 pos = new Vector2(transform.position.x + vec.x * j, transform.position.y + vec.y * j);

                GameObject bomb = Instantiate(_bombPrefab, pos, Quaternion.identity);
                bomb.transform.SetParent(transform);
            }

        }

        Invoke("RemoveBomb", _bombRemoveTime);
    }

    protected override void CheckBox()
    {
        for (int i = 0; i < bombRange.Length; i++)
        {
            Vector2 vec = multiVec[i];
            Debug.Log(vec + "임");
            for (int j = CGameManager._bombState - 1; j >= 0; j--)
            {
                Vector2 pos = new Vector2(transform.position.x + vec.x * j, transform.position.y + vec.y * j);
                Collider2D boxCollision = Physics2D.OverlapCircle(pos, 0.5f, _boxMask);
                if (boxCollision != null)
                {
                    bombRange[i] = j + 1;
                }
            }

            if (bombRange[i] == 0) bombRange[i] = CGameManager._bombState;
        }
    }

}
