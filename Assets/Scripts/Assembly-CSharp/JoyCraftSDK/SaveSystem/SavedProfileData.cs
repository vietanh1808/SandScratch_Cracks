using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedProfileData : JSaveData
	{
		public const int MaxVersion_SavedProfileData = 1;

		[SerializeField]
		private string playerName;

		[SerializeField]
		private string avatarId;

		[SerializeField]
		private string frameId;

		public string PlayerName => null;

		public string AvatarId => null;

		public string FrameId => null;

		public static string GenerateRandomName()
		{
			return null;
		}

		public void SetProfile(string name, string avatarId, string frameId)
		{
		}

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}
	}
}
