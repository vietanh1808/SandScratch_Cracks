using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedUserData : JSaveData
	{
		public const int MaxVersion_SavedUserData = 1;

		private const string Group_Session = "Session";

		[SerializeField]
		private string userId;

		[SerializeField]
		private SerializedDateTime lastTimeLogin;

		[SerializeField]
		private SerializedDateTime lastTimeLogout;

		[SerializeField]
		public int sessionsPlayed;

		[SerializeField]
		private SerializedDateTime lastTimeClaimedAds;

		public SerializedDateTime LastTimeLogin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SerializedDateTime LastTimeLogout
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int SessionsPlayed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public SerializedDateTime LastTimeClaimedAds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UserId
		{
			get
			{
				return null;
			}
			set
			{
			}
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
