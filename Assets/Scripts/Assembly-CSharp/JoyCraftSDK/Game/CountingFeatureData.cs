using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class CountingFeatureData : JBase
	{
		[SerializeField]
		private int fulfilledCount;

		[SerializeField]
		private int index;

		public int FulfilledCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
