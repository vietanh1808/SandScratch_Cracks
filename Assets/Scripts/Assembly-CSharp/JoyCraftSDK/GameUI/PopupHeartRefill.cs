using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PopupHeartRefill : JUIPanel
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateCountdownAsync_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public PopupHeartRefill _003C_003E4__this;

			public CancellationToken ct;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[FormerlySerializedAs("data")]
		public PopupHeartRefillData heartRefillData;

		public TMP_Text totalUserHeartTxt;

		public TMP_Text bonusHeartTxt;

		public TMP_Text buyCoinTxt;

		public TMP_Text nextTimeTxt;

		public RectTransform clockArrowRect;

		public EasingType clockArrowEase;

		public Button buyBtn;

		public Button watchAdsBtn;

		private const float ClockArrowRotateDuration = 0.25f;

		private static readonly UIPanelID[] PanelsHiddenBehind;

		private readonly List<AUIPanel> _hiddenPanels;

		private bool _restorePanelsOnClose;

		private CancellationTokenSource _cts;

		private HeartRefillAction _refillMode;

		private Action _afterRefill;

		private LevelPlayType _playType;

		private bool isCanClick;

		public void SetRefillMode(HeartRefillAction refillMode, Action afterRefill, LevelPlayType playType)
		{
		}

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		private void Start()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnAdsClaimed(ref AEventManager.OnAdsClaimed eventData)
		{
		}

		private void TestWatchADs()
		{
		}

		private void OnClickBuy()
		{
		}

		private void FeedBackAfterGainHeart()
		{
		}

		private void OnClickWatchAds()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Init()
		{
		}

		public override void OnDisappear()
		{
		}

		private void HidePanelsBehind()
		{
		}

		private void RestorePanelsBehind()
		{
		}

		private void Setup()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateCountdownAsync_003Ed__35))]
		private UniTaskVoid UpdateCountdownAsync(CancellationToken ct)
		{
			return default;
		}

		private void RotateClockArrow()
		{
		}

		private string GetHeartNextTime()
		{
			return null;
		}
	}
}
