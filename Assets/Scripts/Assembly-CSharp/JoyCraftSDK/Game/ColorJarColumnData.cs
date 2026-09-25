using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class ColorJarColumnData : JBase
	{
		[Tooltip("Danh sách jar trong cột (từ trên xuống). jars[0] = head (đang nhận).")]
		[SerializeField]
		private List<ColorJarData> jars;

		public List<ColorJarData> Jars => null;
	}
}
