using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(ScrollRect))]
	public class JScrollOverdragLimiter : JMonoBehaviour
	{
		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private float maxOverdrag;

		protected void OnValidate()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnScrollChanged(Vector2 _)
		{
		}

		private void ClampOverdrag()
		{
		}
	}
}
