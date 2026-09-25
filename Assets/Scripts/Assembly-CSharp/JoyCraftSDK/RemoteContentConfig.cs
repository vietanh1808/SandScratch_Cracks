using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK
{
	[Serializable]
	[CreateAssetMenu(fileName = "RemoteContentConfig", menuName = "JoyCraft/Scriptable Objects/Addressable Assets/Remote Content Config")]
	public class RemoteContentConfig : ARemoteContentConfig
	{
		[SerializeField]
		private List<ContentGroup> groups;

		[SerializeField]
		private bool remoteRewriteEnabled;

		[SerializeField]
		private long promptThresholdBytes;

		public override IReadOnlyList<ContentGroup> Groups => null;

		public override bool RemoteRewriteEnabled => false;

		public override long PromptThresholdBytes => 0L;
	}
}
