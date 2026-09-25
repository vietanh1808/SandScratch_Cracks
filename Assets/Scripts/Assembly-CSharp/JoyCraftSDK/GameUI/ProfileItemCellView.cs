using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class ProfileItemCellView : JCellView
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private Image icon;

		[SerializeField]
		private GameObject selected;

		[SerializeField]
		private Button button;

		private string entryId;

		public override void Awake()
		{
		}

		public void SetData(ProfileVisualEntry entry, bool isSelected, Action<string> onClick)
		{
		}

		public void SetSelected(bool isSelected)
		{
		}
	}
}
