using System;
using UnityEngine;

namespace JoyCraftSDK.RemoteConfig
{
	[Serializable]
	public class EconomyData
	{
		[SerializeField]
		public EconomyConfigType type;

		[SerializeField]
		public int coinAmount;
	}
}
