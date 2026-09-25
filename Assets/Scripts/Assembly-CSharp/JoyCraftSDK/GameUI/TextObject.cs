using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class TextObject : ATextObject
	{
		[SerializeField]
		private TextMeshProUGUI[] txts;

		public override void UpdateText(string input)
		{
		}

		private void OnValidate()
		{
		}
	}
}
