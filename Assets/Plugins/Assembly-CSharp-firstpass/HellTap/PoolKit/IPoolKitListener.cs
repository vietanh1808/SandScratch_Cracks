namespace HellTap.PoolKit
{
	public interface IPoolKitListener
	{
		void OnSpawn(Pool pool);

		void OnDespawn();
	}
}
