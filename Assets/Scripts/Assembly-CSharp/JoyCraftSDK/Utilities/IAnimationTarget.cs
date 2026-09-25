using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public interface IAnimationTarget
	{
		Canvas root { get; set; }

		void SetActiveFalse();
	}
}
