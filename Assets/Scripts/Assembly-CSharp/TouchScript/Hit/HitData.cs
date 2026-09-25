using System;
using TouchScript.Layers;
using UnityEngine;

namespace TouchScript.Hit
{
	public struct HitData
	{
		[Flags]
		public enum HitType
		{
			Unknown = 0,
			Screen = 1,
			World3D = 2,
			World2D = Screen | World3D,
			UI = 4
		}

		private HitType type;

		private Transform target;

		private bool screenSpace;

		private TouchLayer layer;

		private RaycastHit raycastHit;

		private RaycastHit2D raycastHit2D;

		private RaycastHitUI raycastHitUI;

		private int sortingLayer;

		private int sortingOrder;

		public HitType Type => HitType.Unknown;

		public Transform Target => null;

		public TouchLayer Layer => null;

		public RaycastHit RaycastHit => default;

		public RaycastHit2D RaycastHit2D => default;

		public RaycastHitUI RaycastHitUI => default;

		public bool ScreenSpace => false;

		public Vector3 Point => default;

		public Vector3 Normal => default;

		public float Distance => 0f;

		public int SortingLayer => 0;

		public int SortingOrder => 0;

		public HitData(Transform target, TouchLayer layer, bool screenSpace = false)
		{
			type = HitType.Unknown;
			this.target = null;
			this.screenSpace = false;
			this.layer = null;
			raycastHit = default;
			raycastHit2D = default;
			raycastHitUI = default;
			sortingLayer = 0;
			sortingOrder = 0;
		}

		public HitData(RaycastHit value, TouchLayer layer, bool screenSpace = false)
		{
			type = HitType.Unknown;
			target = null;
			this.screenSpace = false;
			this.layer = null;
			raycastHit = default;
			raycastHit2D = default;
			raycastHitUI = default;
			sortingLayer = 0;
			sortingOrder = 0;
		}

		public HitData(RaycastHit2D value, TouchLayer layer, bool screenSpace = false)
		{
			type = HitType.Unknown;
			target = null;
			this.screenSpace = false;
			this.layer = null;
			raycastHit = default;
			raycastHit2D = default;
			raycastHitUI = default;
			sortingLayer = 0;
			sortingOrder = 0;
		}

		public HitData(RaycastHitUI value, TouchLayer layer, bool screenSpace = false)
		{
			type = HitType.Unknown;
			target = null;
			this.screenSpace = false;
			this.layer = null;
			raycastHit = default;
			raycastHit2D = default;
			raycastHitUI = default;
			sortingLayer = 0;
			sortingOrder = 0;
		}

		private void updateSortingValues()
		{
		}
	}
}
