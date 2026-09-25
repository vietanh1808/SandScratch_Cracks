using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "LockShakeData", menuName = "GameSDK/LockShakeData")]
	public class LockShakeData : ALockShakeData
	{
		private const string Group_Shake = "Shake";

		[SerializeField]
		public float duration;

		[SerializeField]
		public float angle;

		[SerializeField]
		public int swings;

		[SerializeField]
		public float decay;

		[SerializeField]
		public bool unscaledTime;
	}
}
