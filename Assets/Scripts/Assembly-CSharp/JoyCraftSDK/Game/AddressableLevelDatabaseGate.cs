using UnityEngine;

namespace JoyCraftSDK.Game
{
	public static class AddressableLevelDatabaseGate
	{
		public static bool SessionDownloadConsent { get; set; }

		public static bool SessionBandPrefetchAsked { get; set; }

		public static GatePreCheckResult EvaluatePre(bool initOk, long downloadSize, bool online)
		{
			return GatePreCheckResult.Pass;
		}

		public static GatePreCheckResult EvaluatePre(bool initOk, RemoteContentSizeResult sizeResult, bool online)
		{
			return GatePreCheckResult.Pass;
		}

		public static GateVerdict EvaluatePostDownload(bool downloadSuccess)
		{
			return GateVerdict.Pass;
		}

		public static DownloadPolicy EvaluateDownloadPolicy(NetworkReachability reachability, long downloadSize, long promptThresholdBytes)
		{
			return DownloadPolicy.Silent;
		}

		public static void ResetSessionConsent()
		{
		}

		public static BandPrefetchVerdict EvaluateBandPrefetch(bool addressablesInitialized, bool online, long downloadSize, DownloadPolicy policy, bool sessionConsent)
		{
			return BandPrefetchVerdict.Skip;
		}

		public static BandPrefetchVerdict EvaluateBandPrefetch(bool addressablesInitialized, bool online, RemoteContentSizeResult sizeResult, DownloadPolicy policy, bool sessionConsent)
		{
			return BandPrefetchVerdict.Skip;
		}
	}
}
