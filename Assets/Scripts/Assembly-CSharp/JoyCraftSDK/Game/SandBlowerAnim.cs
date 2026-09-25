using System;
using Animancer;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class SandBlowerAnim : ASandBlowerAnim
	{
		private const string Group_Refs = "References";

		private const string Group_Clips = "Clips";

		[SerializeField]
		private AnimancerComponent animancer;

		[SerializeField]
		private AnimationClip idleClip;

		[SerializeField]
		private AnimationClip appearClip;

		[SerializeField]
		private AnimationClip blowClip;

		[SerializeField]
		private AnimationClip disappearClip;

		public override void PlayIdle()
		{
		}

		public void PlayAppear()
		{
		}

		public override void PlayAppear(Action onComplete)
		{
		}

		public void PlayBlow()
		{
		}

		public override void PlayBlow(Action onComplete)
		{
		}

		public override void StopBlow()
		{
		}

		public void PlayDisappear()
		{
		}

		public override void PlayDisappear(Action onComplete)
		{
		}

		private void PlayOneShot(AnimationClip clip, string clipFieldName, Action onComplete)
		{
		}
	}
}
