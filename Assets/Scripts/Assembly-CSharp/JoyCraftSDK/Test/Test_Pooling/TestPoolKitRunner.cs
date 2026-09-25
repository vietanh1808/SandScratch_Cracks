using HellTap.PoolKit;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Test.Test_Pooling
{
	public class TestPoolKitRunner : JMonoBehaviour
	{
		[SerializeField]
		private Spawner testSpawner;

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
