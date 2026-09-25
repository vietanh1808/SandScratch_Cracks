using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	public class SaveReferencesManager : ASaveReferencesManager
	{
		private const int MinimumReferencesCount = 0;

		[SerializeField]
		private ReferenceDict references;

		public override void Awake()
		{
		}

		public override Object GetReference(string saveUniqueId)
		{
			return null;
		}
	}
}
