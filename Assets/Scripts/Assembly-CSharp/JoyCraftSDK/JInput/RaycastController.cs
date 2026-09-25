using UnityEngine;

namespace JoyCraftSDK.JInput
{
	public class RaycastController : ARaycastController
	{
		private const int MaxHits = 16;

		private static bool isActive;

		private IClickableObject clickableObject;

		private readonly RaycastHit[] _hitsBuffer;

		private void ResetData()
		{
		}

		public override void Awake()
		{
		}

		public void Init()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnUpdate(ref AEventManager.OnUpdate eventdata)
		{
		}

		private bool ShouldBlockRaycast()
		{
			return false;
		}
	}
}
