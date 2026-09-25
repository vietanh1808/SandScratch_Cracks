using System;
using System.Collections.Generic;
using TouchScript.Hit;
using TouchScript.Layers;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript
{
	public interface ILayerManager
	{
		IList<TouchLayer> Layers { get; }

		int LayerCount { get; }

		bool HasExclusive { get; }

		bool AddLayer(TouchLayer layer, int index = -1, bool addIfExists = true);

		bool RemoveLayer(TouchLayer layer);

		void ChangeLayerIndex(int at, int to);

		void ForEach(Func<TouchLayer, bool> action);

		bool GetHitTarget(IPointer pointer, out HitData hit);

		void SetExclusive(Transform target, bool includeChildren = false);

		void SetExclusive(IEnumerable<Transform> targets);

		bool IsExclusive(Transform target);

		void ClearExclusive();
	}
}
