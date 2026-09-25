using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	public class TestUIConfig : JTest
	{
		private const float TimeStep = 2f;

		[SerializeField]
		private AUIConfig uiConfig;

		protected override void OnTest(ref AEventManager.OnStartTestScene eventData)
		{
		}

		private void TestShowAndClose()
		{
		}

		public void PrintPanels()
		{
		}
	}
}
