using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EnhancedUI.EnhancedScroller;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public abstract class JPagesScrollBase : AScroll, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
	{
		[CompilerGenerated]
		private sealed class _003CInitRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JPagesScrollBase _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitRoutine_003Ed__41(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		protected List<JPageCellView> pages;

		[SerializeField]
		public RectTransform viewport;

		[SerializeField]
		private GameObject buttons;

		[SerializeField]
		private List<JPageButton> pageButtons;

		[SerializeField]
		private APageIndicator pageIndicator;

		[SerializeField]
		private int defaultPage;

		[SerializeField]
		private bool prewarmAll;

		[SerializeField]
		private bool fitPageToViewport;

		[HideInInspector]
		public EnhancedScroller.TweenType jumpTweenType;

		[HideInInspector]
		public float jumpTweenTime;

		[HideInInspector]
		public float swipeThreshold;

		[HideInInspector]
		public float flickVelocity;

		[HideInInspector]
		public float minFlickPercent;

		[HideInInspector]
		public UnityEvent<int> onPageChanged;

		private readonly Dictionary<int, JPageCellView> liveCells;

		private float lastPushedProgress;

		private Vector2 dragStartLocal;

		private float dragStartTime;

		private bool isDragging;

		private float lastViewportAxisSize;

		protected abstract EnhancedScroller.ScrollDirectionEnum ScrollDir { get; }

		public int CurrentPageIndex { get; private set; }

		public JPageCellView CurrentPage => null;

		public float PageProgress { get; private set; }

		protected abstract float AxisOf(Vector2 localPoint);

		protected abstract int StepFromDrag(float dragDelta);

		private float CalcPageProgress()
		{
			return 0f;
		}

		private void PushProgress(bool force = false)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected override void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CInitRoutine_003Ed__41))]
		private IEnumerator InitRoutine()
		{
			return null;
		}

		private void BindIndicator()
		{
		}

		private void WireButtons()
		{
		}

		private void UpdateButtonStates(int selectedIndex)
		{
		}

		private void ConfigureScroller()
		{
		}

		private void PrewarmAllPages()
		{
		}

		public override int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		protected float PageSize(int index)
		{
			return 0f;
		}

		public override float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		private float PageStartPosition(int index)
		{
			return 0f;
		}

		public override EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void OnLateUpdate(ref AEventManager.OnLateUpdate eventData)
		{
		}

		private void CheckViewportResize()
		{
		}

		public void OpenPage(int index, bool animate = true)
		{
		}

		private void ParkOtherPages()
		{
		}

		public void OpenPage(int index)
		{
		}

		public void OpenNextPage()
		{
		}

		public void OpenPreviousPage()
		{
		}

		public bool TryOpenPage<T>(bool animate = true) where T : JPageCellView
		{
			return false;
		}
	}
}
