using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class LevelFeaturePair : JBase
	{
		[SerializeField]
		private int pairID;

		[SerializeField]
		private GameFeatureType feature;

		[SerializeField]
		private FeatureItemRef itemA;

		[SerializeField]
		private FeatureItemRef itemB;

		public int PairID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GameFeatureType Feature
		{
			get
			{
				return GameFeatureType.None;
			}
			set
			{
			}
		}

		public FeatureItemRef ItemA
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FeatureItemRef ItemB
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
