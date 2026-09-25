using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.TrophyRoom;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace JoyCraftSDK.GameUI
{
	public class ScreenTrophyRoom : JUIPanel
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass49_0
		{
			public TrophySlotView slot;

			public ScreenTrophyRoom _003C_003E4__this;

			public int itemId;

			internal void _003CRunReveal_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadRoom_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ScreenTrophyRoom _003C_003E4__this;

			public TrophyRoomDef room;

			private int _003CloadVersion_003E5__2;

			private AsyncOperationHandle<TrophyRoomLayout> _003Chandle_003E5__3;

			private UniTask<TrophyRoomLayout>.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CResumePendingCompletion_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ScreenTrophyRoom _003C_003E4__this;

			public int roomId;

			public int resumeVersion;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunReveal_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public TrophySlotView slot;

			public ScreenTrophyRoom _003C_003E4__this;

			public int itemId;

			private _003C_003Ec__DisplayClass49_0 _003C_003E8__1;

			private int _003CrevealDelayVersion_003E5__2;

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

		private const string Group_Refs = "References";

		[SerializeField]
		private TextMeshProUGUI starText;

		[SerializeField]
		private TrophyRoomView roomView;

		[SerializeField]
		private BtnOpenTrophyShop btnOpenShop;

		[SerializeField]
		private TrophyItemRevealEffect revealEffectPrefab;

		[SerializeField]
		private RectTransform revealSpawnAnchor;

		[SerializeField]
		private TextMeshProUGUI roomNameText;

		[SerializeField]
		private TextMeshProUGUI progressText;

		[SerializeField]
		private TextMeshProUGUI earnMoreHintText;

		[SerializeField]
		private GameObject loadingRoot;

		[SerializeField]
		private GameObject failedRoot;

		[SerializeField]
		private BtnClosePanel btnBack;

		[SerializeField]
		private GameObject allCompleteRoot;

		[SerializeField]
		private GameObject introRoot;

		private const string Group_Config = "Config";

		[Tooltip("Chờ popup shop đóng xong (PanelAnim.animOutTime) rồi mới hiện item. HidePanel KHÔNG awaitable nên đây là số TUNE, không suy ra được.")]
		[SerializeField]
		private float _revealStartDelay;

		private AsyncOperationHandle<TrophyRoomLayout> _roomHandle;

		private int _loadedRoomId;

		private int _loadVersion;

		private bool _isRevealing;

		private TrophyItemRevealEffect _activeRevealEffect;

		private int _revealDelayVersion;

		private int _pendingCompletedRoomId;

		private bool _isRoomCompletePopupOpen;

		private bool _isRoomLoading;

		private bool _roomLoadFailed;

		private bool _isResumingPendingCompletion;

		private int _resumeVersion;

		private bool _isIntroOpen;

		private TrophyRoomDef _lastAttemptedRoom;

		private ATrophyRoomManager _trophyRoomManager => null;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void Init()
		{
		}

		private bool TryResumePendingCompletion()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CResumePendingCompletion_003Ed__35))]
		private UniTaskVoid ResumePendingCompletion(int roomId, int resumeVersion)
		{
			return default;
		}

		protected override void RegisterEvent()
		{
		}

		protected override void UnregisterEvent()
		{
		}

		public override void OnDisappear()
		{
		}

		private void OnItemPurchased(ref AEventManager.OnTrophyItemPurchased eventData)
		{
		}

		private void OnRoomCompleted(ref AEventManager.OnTrophyRoomCompleted eventData)
		{
		}

		private void Refresh()
		{
		}

		private void UpdateHeaderTexts(TrophyRoomDef room)
		{
		}

		private void UpdateAllCompleteUI(bool hasPendingCompletion)
		{
		}

		private void UpdateEarnMoreHint(TrophyRoomDef room, bool hasPendingCompletion)
		{
		}

		private void ShowIntro()
		{
		}

		public void RetryLoadRoom()
		{
		}

		public void CloseIntro()
		{
		}

		private void BeginReveal(int itemId)
		{
		}

		[AsyncStateMachine(typeof(_003CRunReveal_003Ed__49))]
		private UniTaskVoid RunReveal(int itemId, TrophySlotView slot)
		{
			return default;
		}

		private void FinishReveal(int itemId)
		{
		}

		private void CancelReveal()
		{
		}

		private void ShowRoomCompletePopup()
		{
		}

		private void OnRoomCompleteClaimed()
		{
		}

		private void UpdateRoomStateUI()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadRoom_003Ed__55))]
		private UniTask LoadRoom(TrophyRoomDef room)
		{
			return default;
		}

		private void ReleaseCurrentRoom()
		{
		}
	}
}
