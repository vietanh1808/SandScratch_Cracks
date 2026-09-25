using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class ADifficultyView : JMonoBehaviour
	{
		[SerializeField]
		protected UIObjectType type;

		protected abstract void UpdateData();

		protected override void OnEnable()
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
