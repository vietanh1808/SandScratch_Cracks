using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class APoolManager : JMonoBehaviour
	{
		public abstract GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent = null);

		public T Spawn<T>(T prefab, Vector3 position, Quaternion rotation, Transform parent = null) where T : MonoBehaviour
		{
			return null;
		}

		public abstract GameObject Spawn(GameObject prefab, Vector3 position, Transform parent = null);

		public T Spawn<T>(T prefab, Vector3 position, Transform parent = null) where T : Component
		{
			return null;
		}

		public abstract GameObject SpawnLocal(GameObject prefab, Vector3 localPosition, Quaternion localRotation, Transform parent);

		public T SpawnLocal<T>(T prefab, Vector3 localPosition, Quaternion localRotation, Transform parent) where T : MonoBehaviour
		{
			return null;
		}

		public abstract void Despawn(GameObject instance);

		public void Despawn<T>(T instance) where T : Component
		{
		}

		public abstract void Despawn(GameObject instance, float delay);

		public void Despawn<T>(T instance, float delay) where T : MonoBehaviour
		{
		}

		public abstract void DespawnAll(GameObject prefab);

		public void DespawnAll<T>(T prefab) where T : MonoBehaviour
		{
		}

		public abstract void DespawnAll();

		public abstract void Prewarm(GameObject prefab, int count = -1);

		public void Prewarm<T>(T prefab, int count = -1) where T : MonoBehaviour
		{
		}

		public abstract void Prewarm(IEnumerable<GameObject> prefabs, int countEach = -1);

		public void Prewarm<T>(IEnumerable<T> prefabs, int countEach = -1) where T : MonoBehaviour
		{
		}

		public abstract int GetActiveCount(GameObject prefab);

		public int GetActiveCount<T>(T prefab) where T : MonoBehaviour
		{
			return 0;
		}

		public abstract int GetAvailableCount(GameObject prefab);

		public int GetAvailableCount<T>(T prefab) where T : MonoBehaviour
		{
			return 0;
		}
	}
}
