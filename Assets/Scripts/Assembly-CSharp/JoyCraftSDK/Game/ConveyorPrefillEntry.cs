using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class ConveyorPrefillEntry : JBase
	{
		[Tooltip("Màu hạt spawn (key match — cast (int) == colorId truyền vào AcceptSand).")]
		[SerializeField]
		private GameObjectColor color;

		[Tooltip("Số HẠT grain spawn lên belt (KHÔNG phải pixel — mỗi hạt = maxGroupSize pixel, cùng quy ước grains<->pixels với DrawTutorialJar/ResolveJarMaxGroupSize).")]
		[SerializeField]
		[Min(1f)]
		private int grainCount;

		public GameObjectColor Color => GameObjectColor.None;

		public int GrainCount => 0;

		public void SetColor(GameObjectColor value)
		{
		}

		public void SetGrainCount(int value)
		{
		}

		public ConveyorPrefillEntry()
		{
		}

		public ConveyorPrefillEntry(GameObjectColor color, int grainCount)
		{
		}
	}
}
