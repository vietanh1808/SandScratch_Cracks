using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public class JScenesManager : AScenesManager
	{
		[SerializeField]
		private List<SceneData> scenesData;

		private readonly HashSet<string> _loadedAdditiveScenes;

		public override bool IsAdditiveSceneLoaded(string sceneName)
		{
			return false;
		}

		public override void RegisterAdditiveScene(string sceneName)
		{
		}

		public override void UnregisterAdditiveScene(string sceneName)
		{
		}

		public override string GetSceneName(SceneIndex sceneIndex)
		{
			return null;
		}
	}
}
