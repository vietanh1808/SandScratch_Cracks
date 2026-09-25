using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.AdminTest
{
	[Serializable]
	public class DevToolsData : JBase
	{
		private const string GROUP_OLD_PROJECT = "Old Project";

		[SerializeField]
		public float cameraRotationX;

		[SerializeField]
		public Color backgroundColor;

		[SerializeField]
		public Sprite backgroundImage;

		[SerializeField]
		public BackgroundMode backgroundMode;
	}
}
