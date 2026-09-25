using System;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public struct SandEmitRequest
	{
		public int colorId;

		public int pixelCount;

		public Vector2 worldPos;

		public Vector2 worldVel;

		public bool ghost;

		public float ghostReleaseY;

		public bool directToJar;

		public SandEmitRequest(int colorId, int pixelCount, Vector2 worldPos, Vector2 worldVel)
		{
			this.colorId = 0;
			this.pixelCount = 0;
			this.worldPos = default;
			this.worldVel = default;
			ghost = false;
			ghostReleaseY = 0f;
			directToJar = false;
		}

		public SandEmitRequest(int colorId, int pixelCount, Vector2 worldPos, Vector2 worldVel, float ghostReleaseY, bool directToJar = false)
		{
			this.colorId = 0;
			this.pixelCount = 0;
			this.worldPos = default;
			this.worldVel = default;
			ghost = false;
			this.ghostReleaseY = 0f;
			this.directToJar = false;
		}
	}
}
