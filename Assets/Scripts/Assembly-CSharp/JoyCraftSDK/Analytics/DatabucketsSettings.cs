using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Analytics
{
	[CreateAssetMenu(fileName = "DatabucketsSettings", menuName = "Databuckets/Settings", order = 0)]
	public sealed class DatabucketsSettings : JScriptableObject
	{
		[Header("Ingest (Databuckets cấp — điền sau)")]
		[Tooltip("API endpoint Databuckets cấp cho JoyCraft. Trống → SDK KHÔNG init (no-op).")]
		[SerializeField]
		private string endpoint;

		[Header("API Keys (public-by-design — như JTD)")]
		[Tooltip("Test key: dataset test/chung. Editor luôn dùng key này.")]
		[SerializeField]
		private string testApiKey;

		[Tooltip("Prod key: dataset thật. Chỉ dùng trên device build khi forceTestKeyOnDevice=false.")]
		[SerializeField]
		private string prodApiKey;

		[Tooltip("CHỈ tác động device build (Editor luôn dùng test key). ON = APK dùng TEST key (QA smoke). Nhớ TẮT trước store release.")]
		[SerializeField]
		private bool forceTestKeyOnDevice;

		[Header("Debug")]
		[Tooltip("Bật log chi tiết init/record ra Console (Editor) / logcat (device).")]
		[SerializeField]
		private bool verbose;

		public bool Verbose => false;

		public string Endpoint => null;

		public bool UseTestKey => false;

		public string ActiveKey => null;

		public bool HasValidKey => false;

		public bool HasEndpoint => false;

		public static DatabucketsSettings Load()
		{
			return null;
		}

		public bool Validate()
		{
			return false;
		}
	}
}
