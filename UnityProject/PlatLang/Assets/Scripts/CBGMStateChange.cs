using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CBGMStateChange : MonoBehaviour
{
    Image img;

    public Sprite normalSprite, pressedSprite;

    void Awake()
    {
        img = GetComponent<Image>();
    }

    void Start()
    {
        if (CSoundManager.instance.isPlayingBGM)
        {
			CSoundManager.instance.PlayBGM();
        }
		else
		{
			img.sprite = pressedSprite;
		}
    }

    public void ChangeBGMState()
    {
        if (CSoundManager.instance.isPlayingBGM)
        {
            CSoundManager.instance.PauseBGM();
            img.sprite = pressedSprite;
        }
        else
        {
            CSoundManager.instance.PlayBGM();
            img.sprite = normalSprite;
        }
    }
}
