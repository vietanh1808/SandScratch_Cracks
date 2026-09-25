using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnLoadSceneAdditive : JButton
	{
		[SerializeField]
		private bool unload;

		[SerializeField]
		private SceneIndex sceneIndex;

		protected override void OnClick()
		{
		}
	}
}
