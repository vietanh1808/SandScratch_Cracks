using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedSettingData : JSaveData
	{
		public const int MaxVersion_SavedSettingData = 1;

		private const string Group_Notification = "Notification";

		private const string Group_Audio = "Audio";

		private const string Group_Gameplay = "Gameplay";

		[SerializeField]
		private bool enablePn;

		[SerializeField]
		private bool requestedPn;

		[SerializeField]
		private bool iosTrackingRequested;

		[SerializeField]
		private float bgmVolume;

		[SerializeField]
		private float sfxVolume;

		[SerializeField]
		private bool enableMusic;

		[SerializeField]
		private bool enableSfx;

		[SerializeField]
		private bool enableCoinMergeSound;

		[SerializeField]
		private bool enableHaptic;

		[SerializeField]
		private bool highPerformance;

		public bool EnablePn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RequestedPn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableHaptic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float BgmVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SfxVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool EnableMusic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableSfx
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableCoinMergeSound
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HighPerformance
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IosTrackingRequested
		{
			get
			{
				return false;
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
