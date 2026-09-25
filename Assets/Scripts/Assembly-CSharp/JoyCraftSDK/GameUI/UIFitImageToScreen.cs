using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Image))]
	public class UIFitImageToScreen : JMonoBehaviour
	{
		[SerializeField]
		private Image image;

		public override void Awake()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		public void Refresh()
		{
		}
	}
}
