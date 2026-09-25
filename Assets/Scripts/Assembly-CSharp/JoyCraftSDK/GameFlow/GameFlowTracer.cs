using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameFlow
{
	public class GameFlowTracer : JMonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitAndSubscribe_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GameFlowTracer _003C_003E4__this;

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

		private const int RingCap = 512;

		public const string ActionPayload = "action";

		private readonly List<GameFlowTrailEntry> _ring;

		private int _seq;

		private string _lastPanel;

		private string _lastActionToken;

		private string _trailPath;

		private bool _ready;

		public static GameFlowTracer Instance { get; private set; }

		public static string TrailRootDir => null;

		public static string BufferPath => null;

		public static string SavedDir => null;

		public override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CWaitAndSubscribe_003Ed__22))]
		private UniTaskVoid WaitAndSubscribe()
		{
			return default;
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public List<GameFlowTrailEntry> Snapshot()
		{
			return null;
		}

		public void Mark(string id)
		{
		}

		private void OnPanelOpen(ref AEventManager.OnPanelStartOpen eventData)
		{
		}

		private void OnSceneFinish(ref AEventManager.OnFinishLoadScene eventData)
		{
		}

		private void OnLevelLoadedHandler(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void OnLevelFinishedHandler(ref AEventManager.OnLevelFinished eventData)
		{
		}

		private void OnLoseConditionHandler(ref AEventManager.OnLevelLoseCondition eventData)
		{
		}

		private void OnCheckpoint(ref AEventManager.OnFlowCheckpoint eventData)
		{
		}

		private void OnButtonClick(ref AEventManager.OnButtonClickSuccess eventData)
		{
		}

		private void Append(string kind, string payload)
		{
		}

		private int SafeHeart()
		{
			return 0;
		}

		private int SafeCoin()
		{
			return 0;
		}

		private void InitTrailFile()
		{
		}

		private void WriteLine(GameFlowTrailEntry entry)
		{
		}
	}
}
