using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public class BtnImage : JBase
	{
		public Image Icon_Locked;

		public Image Icon_PlanePicker;

		public Image Icon_PassengerPicker;

		public Image Icon_Shuffle;

		public Image BtnBg;

		public Image CountBg;

		public Image UnlockLevelBg;

		public void DoAlpha(float alpha, float duration)
		{
		}

		public void Init(BoosterType _type, bool isLocked)
		{
		}

		public void SetSprite(ImgType type, Sprite sprite)
		{
		}
	}
}
