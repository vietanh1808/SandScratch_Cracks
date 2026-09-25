using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class UnlockEntry : JBase
	{
		public UnlockableType unlockable;

		public int level;

		[SerializeReference]
		public AUnlockPayload payload;
	}
}
