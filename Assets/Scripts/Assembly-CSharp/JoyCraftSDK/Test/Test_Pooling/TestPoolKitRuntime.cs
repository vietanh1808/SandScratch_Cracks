using HellTap.PoolKit;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Test.Test_Pooling
{
	public class TestPoolKitRuntime : JTest
	{
		[SerializeField]
		private Spawner spawner;

		private GameObject downloadedPrefab;

		public static TestPoolKitRuntime instance;

		protected override void OnTest(ref AEventManager.OnStartTestScene eventData)
		{
		}

		public override void Awake()
		{
		}

		public void CreatePoolRuntime(GameObject prefab, Transform parent)
		{
		}

		public void CreateSpawnerRuntime(GameObject prefab)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnUpdate(ref AEventManager.OnUpdate eventdata)
		{
		}
	}
}
