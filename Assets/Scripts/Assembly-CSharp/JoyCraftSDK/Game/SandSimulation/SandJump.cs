using System;
using UnityEngine;

namespace JoyCraftSDK.Game.SandSimulation
{
	public class SandJump
	{
		public int id;

		public SandMaterialId materialId;

		public Color32 color;

		public float startX;

		public float startY;

		public float endX;

		public float endY;

		public float jumpPower;

		public float peakFrac;

		public int numJumps;

		public float duration;

		public SandEase ease;

		public int renderRadius;

		public float elapsed;

		public Action<SandJumpResult> onComplete;

		public bool IsDone => false;

		public void Sample(out float fx, out float fy)
		{
			fx = default;
			fy = default;
		}

		public SandJumpResult ToResult()
		{
			return default;
		}
	}
}
