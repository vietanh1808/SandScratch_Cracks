using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnToggleGrainMaterial : JButton
	{
		[SerializeField]
		private Material grain3D;

		[SerializeField]
		private Material grainFlat;

		private void Start()
		{
		}

		protected override void OnClick()
		{
		}

		private void UpdateText(GrainFlowBackend backend)
		{
		}
	}
}
