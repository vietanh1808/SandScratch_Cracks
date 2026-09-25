using System;
using UnityEngine;

namespace JoyCraftSDK.ExternalLink
{
	[Serializable]
	public class ExternalLinkEntry
	{
		[SerializeField]
		private ExternalLinkID id;

		[Tooltip("URL đầy đủ (https://... hoặc mailto:...). Để trống = link chưa cấu hình.")]
		[SerializeField]
		private string url;

		public ExternalLinkID ID => ExternalLinkID.None;

		public string Url => null;
	}
}
