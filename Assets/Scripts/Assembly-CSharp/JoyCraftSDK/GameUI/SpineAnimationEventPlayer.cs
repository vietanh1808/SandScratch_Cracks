using JoyCraftSDK.Utilities;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class SpineAnimationEventPlayer : JMonoBehaviour
	{
		[SerializeField]
		private SkeletonGraphic skeletonGraphic;

		[SerializeField]
		private int trackIndex;

		[SerializeField]
		private float defaultTimeScale;

		public void PlayOnce(string animationName)
		{
		}

		public void PlayLooping(string animationName)
		{
		}

		public void SetTimeScale(float timeScale)
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public void ClearTrack()
		{
		}

		private void Play(string animationName, bool loop)
		{
		}

		private bool TryGetTrack(out TrackEntry trackEntry)
		{
			trackEntry = null;
			return false;
		}

		private bool TryGetAnimationState(out Spine.AnimationState animationState)
		{
			animationState = null;
			return false;
		}
	}
}
