using UnityEngine;

namespace HellTap.PoolKit
{
	public class GlobalPools : ScriptableObject
	{
		[Header("Add Pool Prefabs To The List Below")]
		public GameObject[] globalPools;

		internal void Create()
		{
		}
	}
}
