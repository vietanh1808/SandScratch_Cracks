using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(menuName = "GameSDK/UnlockFeatureConfig", fileName = "Config")]
	public class UnlockFeatureConfig : AUnlockFeatureConfig
	{
		[FormerlySerializedAs("datas")]
		[SerializeField]
		private List<UnlockData> unlockDatas;

		public override VideoClip GetClip(GameFeatureType type)
		{
			return null;
		}

		public override Sprite GetIcon(GameFeatureType type)
		{
			return null;
		}
	}
}
