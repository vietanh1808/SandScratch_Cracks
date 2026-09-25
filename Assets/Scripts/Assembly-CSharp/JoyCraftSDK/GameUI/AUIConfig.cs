using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public abstract class AUIConfig : JScriptableObject
	{
		[Header("All panels")]
		public List<AUIPanel> panelInstances;

		[Header("Paths to panels")]
		public string path;

		public string path2;

		public string path3;

		public string path4;

		public AUIPrefabConfig prefabConfig;

		public AUIDataConfig setupDataConfig;

		public virtual void CreatePanel()
		{
		}
	}
}
