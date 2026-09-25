using System.Collections.Generic;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Clusters
{
	public sealed class Clusters2D
	{
		public const int CLUSTER1 = 0;

		public const int CLUSTER2 = 1;

		private List<Pointer> points;

		private bool dirty;

		private List<Pointer> cluster1;

		private List<Pointer> cluster2;

		private float minPointDistance;

		private float minPointDistanceSqr;

		private bool hasClusters;

		public int PointsCount => 0;

		public float MinPointsDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool HasClusters => false;

		public Vector2 GetCenterPosition(int id)
		{
			return default;
		}

		public Vector2 GetPreviousCenterPosition(int id)
		{
			return default;
		}

		public void AddPoint(Pointer pointer)
		{
		}

		public void AddPoints(IList<Pointer> pointers)
		{
		}

		public void RemovePoint(Pointer pointer)
		{
		}

		public void RemovePoints(IList<Pointer> points)
		{
		}

		public void RemoveAllPoints()
		{
		}

		public void Invalidate()
		{
		}

		private void distributePoints()
		{
		}

		private bool checkClusters()
		{
			return false;
		}

		private void markDirty()
		{
		}

		private void markClean()
		{
		}
	}
}
