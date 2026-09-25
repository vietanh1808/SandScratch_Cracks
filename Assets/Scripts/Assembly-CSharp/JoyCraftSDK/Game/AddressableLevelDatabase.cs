using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "AddressableLevelDatabase", menuName = "GameSDK/AddressableLevelDatabase")]
	public class AddressableLevelDatabase : ALevelDatabase, IAddressableLevelSource
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			public AddressableLevelDatabase _003C_003E4__this;

			public int level;

			public long lastReportedBytes;

			internal void _003CPreloadLevel_003Eb__0(RemoteDownloadStatus status)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPrefetchUpcomingBandCore_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AddressableLevelDatabase _003C_003E4__this;

			public int level;

			private ContentGroupID? _003CinFlightGroupId_003E5__2;

			private ARemoteContentManager _003CremoteContentManager_003E5__3;

			private ContentGroup _003Cgroup_003E5__4;

			private bool _003Conline_003E5__5;

			private UniTask<RemoteContentSizeResult>.Awaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

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
		private struct _003CPreloadLevel_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ALevelData> _003C_003Et__builder;

			public AddressableLevelDatabase _003C_003E4__this;

			public int level;

			public bool background;

			private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

			private int _003Cindex_003E5__2;

			private string _003CvariantId_003E5__3;

			private AssetReference _003ClevelRef_003E5__4;

			private ARemoteContentManager _003CremoteContentManager_003E5__5;

			private ContentGroup _003Cgroup_003E5__6;

			private AsyncOperationHandle<ALevelData> _003Chandle_003E5__7;

			private long _003CdownloadSize_003E5__8;

			private UniTask<RemoteContentSizeResult>.Awaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

			private UniTask<ALevelData>.Awaiter _003C_003Eu__3;

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

		private const string GroupRuntime = "Runtime";

		private const int MaxResident = 2;

		private const long OneMegabyteThreshold = 1048576L;

		[SerializeField]
		private List<LevelAssetEntry> levels;

		[Tooltip("Length kỳ vọng = số entry thật (set qua BuildFromFolder). KHÔNG escape khi rỗng — length-guard phải bắt list bị xoá sạch (mirror GameAssets).")]
		[SerializeField]
		private int levelEntryExactLength;

		[Tooltip("Bật chọn variant theo Remote Config. CHỈ bộ Normal.")]
		[SerializeField]
		private bool applyRemoteVariants;

		private readonly Dictionary<int, ALevelData> _cache;

		private readonly Dictionary<int, AsyncOperationHandle<ALevelData>> _handles;

		private readonly Dictionary<int, string> _cachedVariantIds;

		private readonly List<int> _recency;

		private readonly LevelVariantResolver _variantResolver;

		private readonly HashSet<ContentGroupID> _bandPrefetchInFlight;

		private bool _verified;

		public override int LevelCount => 0;

		public int ExactLength => 0;

		public override ALevelData GetLevel(int level)
		{
			return null;
		}

		public ReleaseDifficulty GetDifficulty(int level)
		{
			return (ReleaseDifficulty)0;
		}

		[AsyncStateMachine(typeof(_003CPreloadLevel_003Ed__19))]
		public UniTask<ALevelData> PreloadLevel(int level, bool background = false)
		{
			return default;
		}

		public string GetVariantId(int level)
		{
			return null;
		}

		public int GetVariantSlot(int level)
		{
			return 0;
		}

		public IReadOnlyList<string> GetVariantIds(int level)
		{
			return null;
		}

		public void PrefetchUpcomingBand(int level)
		{
		}

		[AsyncStateMachine(typeof(_003CPrefetchUpcomingBandCore_003Ed__24))]
		private UniTaskVoid PrefetchUpcomingBandCore(int level)
		{
			return default;
		}

		private void ShowBandPrefetchConsentPopup(ContentGroup group, long downloadSizeBytes, int level)
		{
		}

		private bool IsCachedVariant(int index, string variantId)
		{
			return false;
		}

		private int ResolveIndex(int level)
		{
			return 0;
		}

		public static int ToContentLevel(int level, int count)
		{
			return 0;
		}

		private void Touch(int index)
		{
		}

		private void EvictIfNeeded()
		{
		}

		private void VerifyOnce()
		{
		}
	}
}
