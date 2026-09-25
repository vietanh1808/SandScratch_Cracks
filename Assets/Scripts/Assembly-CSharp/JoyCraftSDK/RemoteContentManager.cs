using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace JoyCraftSDK
{
	public class RemoteContentManager : ARemoteContentManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckForCatalogUpdateAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public RemoteContentManager _003C_003E4__this;

			private UniTask<List<string>>.Awaiter _003C_003Eu__1;

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
		private struct _003CDownloadAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public RemoteContentManager _003C_003E4__this;

			public ContentGroupID id;

			public IProgress<RemoteDownloadStatus> progress;

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
		private struct _003CGetDownloadSizeAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RemoteContentSizeResult> _003C_003Et__builder;

			public ContentGroupID id;

			public RemoteContentManager _003C_003E4__this;

			private string _003Clabel_003E5__2;

			private UniTask<RemoteContentSizeResult>.Awaiter _003C_003Eu__1;

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

		private const long DefaultPromptThresholdBytes = 104857600L;

		private static readonly Regex CatalogBundleUrlPattern;

		private readonly IReadOnlyList<ContentGroup> _groups;

		private readonly bool _remoteRewriteEnabled;

		private readonly IRemoteContentProvider _provider;

		private readonly long _promptThresholdBytes;

		public override long PromptThresholdBytes => 0L;

		public RemoteContentManager(IReadOnlyList<ContentGroup> groups, bool remoteRewriteEnabled, IRemoteContentProvider provider, long promptThresholdBytes = 104857600L)
		{
		}

		public override bool TryGetGroupForLevel(int level, out ContentGroup group)
		{
			group = default;
			return false;
		}

		public static bool TryFindGroupForLevel(IReadOnlyList<ContentGroup> groups, int level, out ContentGroup group)
		{
			group = default;
			return false;
		}

		public override bool TryGetUpcomingGroup(int level, out ContentGroup group)
		{
			group = default;
			return false;
		}

		public string TransformInternalId(string internalId)
		{
			return null;
		}

		public override void ApplyInternalIdTransform()
		{
		}

		public static string GetLabelForGroup(ContentGroupID id)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetDownloadSizeAsync_003Ed__15))]
		public override UniTask<RemoteContentSizeResult> GetDownloadSizeAsync(ContentGroupID id)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CCheckForCatalogUpdateAsync_003Ed__16))]
		public override UniTask<bool> CheckForCatalogUpdateAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__17))]
		public override UniTask<bool> DownloadAsync(ContentGroupID id, IProgress<RemoteDownloadStatus> progress = null)
		{
			return default;
		}
	}
}
