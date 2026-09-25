using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace JoyCraftSDK
{
	public interface IRemoteContentProvider
	{
		UniTask<RemoteContentSizeResult> GetDownloadSizeAsync(object key);

		UniTask<List<string>> CheckForCatalogUpdatesAsync();

		UniTask UpdateCatalogsAsync(List<string> catalogs);

		UniTask DownloadDependenciesAsync(object key, IProgress<RemoteDownloadStatus> progress = null);
	}
}
