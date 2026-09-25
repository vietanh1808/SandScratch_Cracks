using System;
using UnityEngine;

namespace JoyCraftSDK
{
	[Serializable]
	public struct ContentGroup
	{
		[SerializeField]
		private ContentGroupID id;

		[SerializeField]
		private int firstLevel;

		public ContentGroupID Id => ContentGroupID.None;

		public int FirstLevel => 0;

		public int PrefetchStartLevel => 0;

		public ContentGroup(ContentGroupID id, int firstLevel)
		{
			this.id = ContentGroupID.None;
			this.firstLevel = 0;
		}

		public bool ContainsLevel(int level)
		{
			return false;
		}
	}
}
