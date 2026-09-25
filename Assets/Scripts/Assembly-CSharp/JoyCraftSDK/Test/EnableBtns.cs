using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	public class EnableBtns : JButton
	{
		[SerializeField]
		private List<JButton> buttons;

		[SerializeField]
		private bool enable;

		protected override void OnClick()
		{
		}
	}
}
