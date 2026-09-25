using System;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class ARemoteContentManager : JBase
	{
		public abstract long PromptThresholdBytes { get; }

		public abstract UniTask<RemoteContentSizeResult> GetDownloadSizeAsync(ContentGroupID id);

		public abstract UniTask<bool> CheckForCatalogUpdateAsync();

		public abstract UniTask<bool> DownloadAsync(ContentGroupID id, IProgress<RemoteDownloadStatus> progress = null);

		public abstract bool TryGetGroupForLevel(int level, out ContentGroup group);

		public abstract bool TryGetUpcomingGroup(int level, out ContentGroup group);

		public abstract void ApplyInternalIdTransform();
	}
}
