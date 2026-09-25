using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	[Serializable]
	public class SceneData
	{
		public SceneIndex SceneIndex;

		[SerializeField]
		public SceneReference scene;
	}
}
