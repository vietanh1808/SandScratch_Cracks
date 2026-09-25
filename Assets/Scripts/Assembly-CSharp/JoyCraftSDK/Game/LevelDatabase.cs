using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "LevelDatabase", menuName = "GameSDK/LevelDatabase")]
	public class LevelDatabase : ALevelDatabase
	{
		private const string GroupRuntime = "Runtime";

		[SerializeField]
		private List<ALevelData> levels;

		public override int LevelCount => 0;

		public override ALevelData GetLevel(int level)
		{
			return null;
		}
	}
}
