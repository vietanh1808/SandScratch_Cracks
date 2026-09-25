using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class LevelFeatureData : JBase
	{
		[SerializeField]
		private List<LevelFeaturePair> pairs;

		[SerializeField]
		private List<CountingFeatureData> queues;

		[SerializeField]
		private List<CountingFeatureData> stations;

		public List<LevelFeaturePair> Pairs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<CountingFeatureData> Queues
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<CountingFeatureData> Stations
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
