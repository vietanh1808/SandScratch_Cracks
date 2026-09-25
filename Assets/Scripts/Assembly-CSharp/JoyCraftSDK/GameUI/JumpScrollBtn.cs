using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class JumpScrollBtn : JButton
	{
		private const string Group_Config = "Config";

		private const string Group_Refs = "References";

		[SerializeField]
		private bool center;

		[SerializeField]
		private bool animate;

		[SerializeField]
		private GameObject activeArea;

		[SerializeField]
		private GameObject deactiveArea;

		[SerializeField]
		private Image icon;

		private AScroll scroll;

		private int targetIndex;

		private Action onClicked;

		public void Init(AScroll scroll, int targetIndex, string label, Sprite iconSprite, Action onClicked = null)
		{
		}

		public void SetSelected(bool selected)
		{
		}

		public void SetIcon(Sprite iconSprite)
		{
		}

		protected override void OnClick()
		{
		}
	}
}
