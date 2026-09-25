using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class ATutorialHandIndicator : JMonoBehaviour
	{
		public abstract void PlayDragObjectAnimation(Vector3 from, Vector3 to, float playTime);

		public abstract void PlayDragObjectAnimation(List<Vector3> paths, float playTime);

		public abstract void PlayDragStrokesAnimation(List<List<Vector3>> strokes, List<float> strokeTimes);

		public abstract void Follow(Transform target, bool targetIsWordSpace = true);

		public abstract void MoveInThenFollow(Transform target, bool targetIsWordSpace);

		public abstract void MoveThenClick(Transform fromButton, Vector3 worldTargetCenter);

		public abstract void Stop();

		public abstract void PlayClickAnimation();

		public abstract void PlayClickAnimation(Vector3 targetPos);
	}
}
