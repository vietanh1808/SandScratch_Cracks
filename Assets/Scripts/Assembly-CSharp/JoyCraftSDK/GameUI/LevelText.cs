using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class LevelText : ALevelText
	{
		[SerializeField]
		private TextMeshProUGUI text;

		protected override void OnEnable()
		{
		}

		public override void Init()
		{
		}

		private void OnValidate()
		{
		}
	}
}
