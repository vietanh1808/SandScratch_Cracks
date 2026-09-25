using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedPendingAbandonData : JSaveData
	{
		public const int MaxVersion_SavedPendingAbandonData = 2;

		[SerializeField]
		private bool hasPending;

		[SerializeField]
		private long backgroundUtcTicks;

		[SerializeField]
		private string sessionId;

		[SerializeField]
		private float timeSpent;

		[SerializeField]
		private int itemsTotal;

		[SerializeField]
		private int itemsCleared;

		[SerializeField]
		private LevelPlayType playType;

		[SerializeField]
		private string variantId;

		public bool HasPending => false;

		public long BackgroundUtcTicks => 0L;

		public string SessionId => null;

		public float TimeSpent => 0f;

		public int ItemsTotal => 0;

		public int ItemsCleared => 0;

		public LevelPlayType PlayType => LevelPlayType.Home;

		public string VariantId => null;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public override bool UpdateVersionIncremental(int currentVersion)
		{
			return false;
		}

		public void MarkPending(long utcTicks, string sessionId, float timeSpent, int itemsTotal, int itemsCleared, LevelPlayType playType, string variantId)
		{
		}

		public void Clear()
		{
		}
	}
}
