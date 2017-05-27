using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CLangCanvasPanelState : CCanvasPanelState {

	public Sprite[] characterSprite;
	Button _btn;

	void Awake()
	{
		_btn = GetComponent<Button>();
	}

	public override void ChangeNormal()
	{
		_btn.image.color = _btn.colors.highlightedColor;
		isSelect = false;
	}

	public override void ChangePressed()
	{
		CMainManger.instance.LangStateReset();

		_btn.image.color = _btn.colors.pressedColor;
		CMainManger.instance.characterImage[0].sprite = characterSprite[0];
		CMainManger.instance.characterImage[1].sprite = characterSprite[1];
		isSelect = true;
	}


}
