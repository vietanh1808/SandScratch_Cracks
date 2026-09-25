using System;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public struct SwapDirectionEntry
	{
		[Tooltip("Object áp hướng này.")]
		[SerializeField]
		private SwapElementKind kind;

		[Tooltip("Hướng object MỚI trượt VÀO rest-pose.")]
		[SerializeField]
		private SwapDirection enterDir;

		[Tooltip("Hướng object CŨ trượt RA khỏi màn.")]
		[SerializeField]
		private SwapDirection exitDir;

		public SwapElementKind Kind => SwapElementKind.Picture;

		public SwapDirection EnterDir => SwapDirection.Down;

		public SwapDirection ExitDir => SwapDirection.Down;
	}
}
