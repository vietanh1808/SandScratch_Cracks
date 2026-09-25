using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class APageIndicator : JMonoBehaviour
	{
		public abstract void Bind(IReadOnlyList<RectTransform> anchors);

		public abstract void SetProgress(float pageProgress);
	}
}
