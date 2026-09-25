using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class GameplayTestButtons : JMonoBehaviour
	{
		[SerializeField]
		private GameObject btnWin;

		[SerializeField]
		private GameObject btnLose;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void Apply(bool isOn)
		{
		}
	}
}
