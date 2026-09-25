using System;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class TimedBuffConfigPoint
	{
		[Tooltip("Loai buff co thoi han (infinite lives, x2 coin...). Key de TimedBuffManager tra config.")]
		public BuffType type;

		[Tooltip("Do manh cua buff. 1 = on/off (vd infinite lives); 2 = x2; ... Duoc luu vao save luc kich hoat.")]
		public float magnitude;
	}
}
