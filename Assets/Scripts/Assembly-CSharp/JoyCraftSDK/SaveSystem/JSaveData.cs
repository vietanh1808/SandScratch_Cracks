using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public abstract class JSaveData : JBase, ISavableData, IDataVersion, ISaveLoadCallbackReceiver
	{
		[FormerlySerializedAs("dataVersion")]
		[SerializeField]
		private int currentVersion;

		public int GetCurrentVersion()
		{
			return 0;
		}

		public void SetCurrentVersion(int version)
		{
		}

		public void UpdateVersion()
		{
		}

		public virtual bool UpdateVersionIncremental(int currentVersion)
		{
			return false;
		}

		public void BeforeSaving()
		{
		}

		public void AfterLoading()
		{
		}

		public virtual bool IsValid()
		{
			return false;
		}

		public abstract int GetMaxVersion();

		public abstract List<ISavableData> GetChildrenISavableData();

		protected virtual void OnBeforeSaving()
		{
		}

		protected virtual void OnAfterLoading()
		{
		}
	}
}
