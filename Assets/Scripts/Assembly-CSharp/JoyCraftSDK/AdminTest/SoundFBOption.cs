using JoyCraftSDK.Utilities;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace JoyCraftSDK.AdminTest
{
	public class SoundFBOption : ASoundFBOption
	{
		[SerializeField]
		private SoundType type;

		[SerializeField]
		private MMF_Player mmfPlayer;

		private AudioClip originalClip;

		private MMF_MMSoundManagerSound mmfSound => null;

		private void OnSfxOptionChange(SoundType type, AudioClip clip)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnValidate()
		{
		}
	}
}
