using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "TrailEffectData", menuName = "VFX/Trail Effect Data")]
	public class TrailEffectData : JScriptableObject
	{
		[Tooltip("Trail width scales with particle size")]
		public float scaleFactor;

		[Tooltip("Color applied to trail material")]
		public Color color;
	}
}
