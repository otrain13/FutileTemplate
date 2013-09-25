using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class MainPage : AbstractPage
{
	public MainPage ()
	{
	}

	override public void Start()
	{	
		FSprite sprite = new FSprite("WhiteBox");
		sprite.color = RXColor.GetColorFromHex(0xffff00);
		sprite.scale = 10.0f;
		AddChild(sprite);

		FLabel lbl = new FLabel("CubanoInnerShadow", "HELLO WORLD");
		lbl.color = Color.black;
		AddChild(lbl);
	}
	
	override public void Destroy()
	{	
	}
}

