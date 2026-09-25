using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class TouchFxController : JMonoBehaviour
	{
		[Tooltip("Prefab hiệu ứng chạm (VFX_Touch — UIParticle). Bỏ trống -> không nảy gì.")]
		[SerializeField]
		private GameObject vfxTouchPrefab;

		[Tooltip("Trả instance về pool sau bao lâu (giây) — khớp/nhỉnh hơn đời particle.")]
		[SerializeField]
		private float autoDespawnDelay;

		public void PlayAt(Vector2 screenPos)
		{
		}
	}
}
