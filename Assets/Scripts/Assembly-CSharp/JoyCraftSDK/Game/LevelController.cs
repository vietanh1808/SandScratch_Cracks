using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;
using VContainer;

namespace JoyCraftSDK.Game
{
	public class LevelController : ALevelController
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSpawnLevel_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public LevelController _003C_003E4__this;

			public int level;

			public LevelPlayType playType;

			private IAddressableLevelSource _003CaddressableSource_003E5__2;

			private UniTask<ALevelData>.Awaiter _003C_003Eu__1;

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

		private readonly LevelSpawner levelSpawner;

		private bool _isLevelLoaded;

		private bool _isLevelStart;

		private bool _isLevelFinished;

		private ALevelDatabase currentDatabase;

		private bool isHardMode;

		private string _currentVariantId;

		private int CurrentLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private float LastAttemptProgressPosX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override ALevelDatabase CurrentDatabase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsHardMode => false;

		public override ALevelData LevelData { get; protected set; }

		public override ColorDefinitionSO ColorDefinition { get; }

		public override string CurrentVariantId => null;

		[Inject]
		public LevelController(LevelSpawner levelSpawner)
		{
		}

		public override int GetCurrentVariantSlot()
		{
			return 0;
		}

		public override IReadOnlyList<string> GetCurrentVariantIds()
		{
			return null;
		}

		public override int GetCurrentLevel()
		{
			return 0;
		}

		public override int GetMaxLevel()
		{
			return 0;
		}

		public override bool IsLevelStart()
		{
			return false;
		}

		public override bool IsLevelFinished()
		{
			return false;
		}

		public override bool IsInLevel()
		{
			return false;
		}

		public override ReleaseDifficulty GetLevelDifficulty(int level = -1)
		{
			return (ReleaseDifficulty)0;
		}

		public override void LoadCurrentLevel(LevelPlayType playType)
		{
		}

		public override void LoadCustomLevel(int level)
		{
		}

		public override void UnloadCurrentLevel()
		{
		}

		public override void SetFinishLevel(bool isFinished)
		{
		}

		public void PromotePrebuiltLevel(LevelPlayType playType)
		{
		}

		public ALevelData GetLevelData(int level)
		{
			return null;
		}

		public void PrefetchLevel(int level)
		{
		}

		public void ToggleLevelDatabase()
		{
		}

		private void EnsureCurrentDatabase()
		{
		}

		private void InitLoadLevel()
		{
		}

		private int GetNextLevel(int count = 1)
		{
			return 0;
		}

		private void LoadLevel(int level, LevelPlayType playType)
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnLevel_003Ed__48))]
		private UniTaskVoid SpawnLevel(int level, LevelPlayType playType)
		{
			return default;
		}

		private void RepositionCamera()
		{
		}

		private void BuildSandLevel()
		{
		}

		private void OnLoadLevelSuccess(LevelPlayType playType)
		{
		}

		private void OnSetupScene(ref AEventManager.OnSetupScene eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		protected virtual void AdvanceOnFinish(LevelFinishReason reason)
		{
		}

		protected virtual int GetSavedLevel()
		{
			return 0;
		}

		protected virtual void SetSavedLevel(int value)
		{
		}

		protected virtual void OnAdvanceSideEffects()
		{
		}

		public override void Initialize()
		{
		}
	}
}
