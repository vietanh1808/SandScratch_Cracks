using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Build
{
	[Serializable]
	[CreateAssetMenu(fileName = "ReleaseChecklistConfig", menuName = "JoyCraft/J Build Tool/Release Checklist Config")]
	public class ReleaseChecklistConfig : AReleaseChecklistConfig
	{
		[Header("Versioning")]
		[Tooltip("Bundle version code của lần release gần nhất. Build mới phải lớn hơn số này.")]
		[SerializeField]
		private int lastReleasedBundleVersionCode;

		[Tooltip("Build number (CFBundleVersion) của lần release iOS gần nhất.")]
		[SerializeField]
		private int iosBuildNumber;

		[Header("Firebase")]
		[Tooltip("Firebase App ID (Android) cho crashlytics:symbols:upload. VD: 1:123:android:abc.")]
		[SerializeField]
		private string firebaseAndroidAppId;

		[Tooltip("URL trang Firebase Console → Remote Config (mở khi confirm bước Remote Config ở Post-Build Checklist).")]
		[SerializeField]
		private string firebaseRemoteConfigUrl;

		[Tooltip("Đường (relative repo-root) tới ledger symbol-upload git-tracked. Rỗng = mặc định Docs/Game/Release/symbol-upload-log.txt.")]
		[SerializeField]
		private string symbolUploadLogPath;

		[Tooltip("Tự động upload symbols → Firebase Crashlytics ngay sau khi release build (Android) thành công. Fail không làm hỏng build.")]
		[SerializeField]
		private bool autoUploadSymbolsToFirebase;

		[Header("After-Build Reminders (log đỏ sau khi build xong)")]
		[SerializeField]
		private List<AfterBuildReminder> afterBuildReminders;

		public override int LastReleasedBundleVersionCode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int IosBuildNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string FirebaseAndroidAppId => null;

		public override string FirebaseRemoteConfigUrl => null;

		public override string SymbolUploadLogPath => null;

		public override bool AutoUploadSymbolsToFirebase => false;

		public override List<AfterBuildReminder> AfterBuildReminders => null;
	}
}
