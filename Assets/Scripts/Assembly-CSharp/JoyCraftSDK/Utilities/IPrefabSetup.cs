using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public interface IPrefabSetup
	{
		void SetupOnCreateNewPrefab(GameObject gameObject, string className);
	}
}
