using UnityEngine;

namespace JoyCraftSDK
{
	[CreateAssetMenu(fileName = "SoundData", menuName = "GameSDK/SoundData")]
	public class SoundData : ASoundData
	{
		[SerializeField]
		private float delayWinScreen;

		public override float DelayWinScreen => 0f;
	}
}
