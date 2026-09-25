using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedLocalizationData : JSaveData
	{
		public const int MaxVersion_SavedLocalizationData = 1;

		[SerializeField]
		private LocalizationLocale activeLocale;

		public void SetActiveLocale(LocalizationLocale newLocale)
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

		protected override void OnAfterLoading()
		{
		}
	}
}
