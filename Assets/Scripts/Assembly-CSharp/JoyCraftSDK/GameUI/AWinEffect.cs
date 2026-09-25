using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class AWinEffect : JMonoBehaviour
	{
		public abstract void Show(Action callback = null);

		public abstract void Show(Vector3 endPosition, Action callback = null);

		public abstract void Show(Transform target, Action callback = null);
	}
}
