using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class AIceBlocker : JMonoBehaviour
	{
		public abstract Vector3 BreakedTargetPosition { get; }

		public abstract bool PlayBroke();

		public abstract void Setup(int totalStepToBreak);

		public abstract void SetVisible(bool visible);

		public abstract void SetClipWorldY(float worldY);

		public abstract void ApplyBaseScale(Vector3 localScale);
	}
}
