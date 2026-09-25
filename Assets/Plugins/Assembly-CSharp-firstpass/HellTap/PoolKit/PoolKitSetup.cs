using UnityEngine;

namespace HellTap.PoolKit
{
	public class PoolKitSetup : MonoBehaviour
	{
		[Header("PoolKit Settings")]
		public bool updatePoolKitSettings;

		public PoolKit.RenameFormat renameObjectsInPool;

		public bool onlyRenameObjectsInEditor;

		public bool debugPoolKit;

		[Header("Options")]
		public bool dontDestroyOnLoad;

		private void Awake()
		{
		}
	}
}
