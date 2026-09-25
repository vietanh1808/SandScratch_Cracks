using System;
using System.Collections.Generic;
using TouchScript.Hit;
using TouchScript.Layers;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Core
{
	internal sealed class LayerManagerInstance : MonoBehaviour, ILayerManager
	{
		private static LayerManagerInstance instance;

		private static bool shuttingDown;

		private ITouchManager manager;

		private List<TouchLayer> layers;

		private int layerCount;

		private HashSet<int> exclusive;

		private int exclusiveCount;

		private int clearExclusiveDelay;

		private List<Transform> tmpList;

		public static ILayerManager Instance => null;

		public IList<TouchLayer> Layers => null;

		public int LayerCount => 0;

		public bool HasExclusive => false;

		public bool AddLayer(TouchLayer layer, int index = -1, bool addIfExists = true)
		{
			return false;
		}

		public bool RemoveLayer(TouchLayer layer)
		{
			return false;
		}

		public void ChangeLayerIndex(int at, int to)
		{
		}

		public void ForEach(Func<TouchLayer, bool> action)
		{
		}

		public bool GetHitTarget(IPointer pointer, out HitData hit)
		{
			hit = default;
			return false;
		}

		public void SetExclusive(Transform target, bool includeChildren = false)
		{
		}

		public void SetExclusive(IEnumerable<Transform> targets)
		{
		}

		public bool IsExclusive(Transform target)
		{
			return false;
		}

		public void ClearExclusive()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void frameFinishedHandler(object sender, EventArgs eventArgs)
		{
		}
	}
}
