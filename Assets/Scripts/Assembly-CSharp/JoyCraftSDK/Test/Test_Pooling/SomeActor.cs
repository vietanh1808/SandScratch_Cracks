using HellTap.PoolKit;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Test.Test_Pooling
{
	public class SomeActor : JMonoBehaviour, IPoolKitListener
	{
		[SerializeField]
		private Despawner despawner;

		public void OnSpawn(Pool pool)
		{
		}

		public void OnDespawn()
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
