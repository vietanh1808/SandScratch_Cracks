using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class FeatureItemRef : JBase
	{
		[SerializeField]
		private int holderIndex;

		[SerializeField]
		private int index;

		public int HolderIndex
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
