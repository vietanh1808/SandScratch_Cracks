using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BundleSnapScroll : JMonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IPointerDownHandler
	{
		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private float snapDuration;

		[SerializeField]
		private float minSwipeDistance;

		[SerializeField]
		private float flickVelocityThreshold;

		private readonly List<RectTransform> pages;

		private float dragBeginScreenX;

		public int CurrentIndex { get; private set; }

		public int PageCount => 0;

		private RectTransform Viewport => null;

		public override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		public void Refresh()
		{
		}

		public void SnapTo(int index, bool instant)
		{
		}

		private void RebuildPages()
		{
		}

		private float ComputeTargetContentX(RectTransform page)
		{
			return 0f;
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
