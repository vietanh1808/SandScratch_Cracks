using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnChangeSound : JButton
	{
		[SerializeField]
		private SoundType type;

		[SerializeField]
		private AudioClip clip;

		protected override void OnClick()
		{
		}
	}
}
