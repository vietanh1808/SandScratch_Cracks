using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.AdminTest
{
	[Serializable]
	public class CheatData : JBase
	{
		private const string GROUP_LEVEL = "Level";

		[SerializeField]
		public int testLevelToLoad;

		[SerializeField]
		public int textLevelToLoad;
	}
}
