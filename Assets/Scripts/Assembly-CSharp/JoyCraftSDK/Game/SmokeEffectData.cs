using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "SmokeEffectData", menuName = "VFX/Smoke Effect Data")]
	public class SmokeEffectData : JScriptableObject
	{
		[Serializable]
		public struct Record
		{
			public GameObjectColor objectColor;

			public Color color;

			public Material fillMaterial;
		}

		public List<Record> records;

		[SerializeField]
		private Material sampleFillMaterial;

		private void CreateSample()
		{
		}
	}
}
