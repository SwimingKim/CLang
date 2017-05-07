using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CStarItem : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.name == "PlayerShip")
		{
            // GameObject.Find("게임오브젝트이름") : 게임오브젝트를 검색함
            GameObject starCount = GameObject.Find("StarCountText");

            // 게임 오브젝트의 컴포넌트 중에 지정한 컴포넌트 타입을 참조함

			// 별카운트 텍스트 오브젝트의 Text 컴포넌트를 참조함
	        Text countText = starCount.GetComponent<Text>();

            // string -> int 변경
            int count = int.Parse(countText.text);
            count += 10; // 별점 증가

            // int -> string
            countText.text = count.ToString();

            // 아이템을 삭제함
            Destroy(gameObject);
        }

		
	}


}
