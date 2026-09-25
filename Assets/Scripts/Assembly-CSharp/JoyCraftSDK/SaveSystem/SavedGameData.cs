using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedGameData : JSaveData, ISavableData, IDataVersion, ISaveLoadCallbackReceiver
	{
		public const int MaxVersion_SavedGameData = 1;

		[SerializeField]
		private SavedPlayerProgressData savedPlayerProgressData;

		[SerializeField]
		private SavedUserData savedUserData;

		[SerializeField]
		private SavedBuyData savedBuyData;

		[SerializeField]
		private SavedSettingData savedSettingData;

		[ES3NonSerializable]
		private List<ISavableData> _childDataStructures;

		[ES3NonSerializable]
		private bool _listInited;

		public SavedPlayerProgressData SavedPlayerProgressData => null;

		public SavedUserData SavedUserData => null;

		public SavedBuyData SavedBuyData => null;

		public SavedSettingData SavedSettingData => null;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
