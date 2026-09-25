using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JTD
{
	[CreateAssetMenu(fileName = "JTDSettings", menuName = "JTD/Settings", order = 0)]
	public sealed class JTDSettings : JScriptableObject
	{
		public const string DefaultEndpoint = "https://api.joycraftgames.net";

		[Header("API Keys (public-by-design — Decision 09)")]
		[Tooltip("Test key: event gắn is_test=1, BỊ LOẠI khỏi prod metric. Editor luôn dùng key này. Public-by-design (Decision 09).")]
		[SerializeField]
		private string testApiKey;

		[Tooltip("Prod key: event tính vào metric thật (is_test=0). Chỉ dùng trên device build khi forceTestKeyOnDevice=false.")]
		[SerializeField]
		private string prodApiKey;

		[Tooltip("CHỈ tác động trên device/APK build (Editor luôn dùng test key bất kể cờ này). ON = APK dùng TEST key → event gắn is_test=1 → LÊN tab Live Debug dashboard + BỊ LOẠI khỏi prod metric. Dùng QA smoke trên máy thật. Nhớ TẮT trước store release để event vào metric thật.")]
		[SerializeField]
		private bool forceTestKeyOnDevice;

		[Header("Transport")]
		[Tooltip("Base URL ingest. Rỗng → dùng DefaultEndpoint (api.joycraftgames.net). Trailing slash tự bỏ.")]
		[SerializeField]
		private string endpoint;

		[Tooltip("Bật log chi tiết send/response ra Console (Editor) / logcat (device). CHỈ là log — KHÔNG quyết định event có gửi hay có lên tab Live Debug. Editor + editorSendEvents ON tự bật verbose dù cờ này OFF.")]
		[SerializeField]
		private bool verbose;

		[Header("Editor")]
		[Tooltip("CHỈ tác động trên Unity Editor. ON = Editor gửi event thật lên backend + tự bật verbose. OFF (default) = Editor chỉ queue vào PlayerPrefs, KHÔNG gửi. Build APK/device KHÔNG bị ảnh hưởng (luôn gửi). KHÔNG liên quan tab Live Debug của APK — cái đó do forceTestKeyOnDevice.")]
		[SerializeField]
		private bool editorSendEvents;

		public bool Verbose => false;

		public bool EditorSendEvents => false;

		public string Endpoint => null;

		public bool UseTestKey => false;

		public string ActiveKey => null;

		public bool HasValidKey => false;

		public static JTDSettings Load()
		{
			return null;
		}

		public bool Validate()
		{
			return false;
		}
	}
}
