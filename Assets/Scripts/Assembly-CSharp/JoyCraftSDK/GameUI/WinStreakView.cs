using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using JoyCraftSDK.WinStreak;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class WinStreakView : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Bar = "Segmented Bar";

		private const string Group_Anim = "Animation";

		[SerializeField]
		private GameObject root;

		[Tooltip("Optional: raw streak number.")]
		[SerializeField]
		private TMP_Text streakText;

		[Tooltip("Optional: 'Best: N'.")]
		[SerializeField]
		private TMP_Text bestText;

		[Tooltip("Optional: single tier icon, tinted with WinStreakBarState.IconColor (earned tier, or the config's no-reward color).")]
		[SerializeField]
		private Image tierIcon;

		[SerializeField]
		private RectTransform segmentContainer;

		[Tooltip("Optional (no bar when unset). Inactive child used as template; instantiated MaxTierStreak times under segmentContainer.")]
		[SerializeField]
		private WinStreakSegment segmentTemplate;

		[Tooltip("'reached/max', e.g. 2/3.")]
		[SerializeField]
		private TMP_Text progressText;

		[Tooltip("True: the cell of the streak just earned tweens 0->1 (ScreenWin). False: show the final state at once (PopupPreLevel). Owner may override at runtime via AnimateEarned.")]
		[SerializeField]
		private bool animateEarned;

		[SerializeField]
		private float delayTime;

		[SerializeField]
		private float playTime;

		[Tooltip("ScreenWin: after a win fills a tier, hold on the full bar this long before jumping to the next tier empty. 0 = jump immediately.")]
		[SerializeField]
		private float advanceHoldTime;

		private readonly List<WinStreakSegment> _segments;

		public bool AnimateEarned
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		public void Refresh()
		{
		}

		private void RefreshBar(AWinStreakConfig winStreakConfig, int streak)
		{
		}

		private void ShowNextTierEmpty(AWinStreakConfig winStreakConfig, int streak)
		{
		}

		private void SetProgressText(int reached, int count)
		{
		}

		private void EnsureSegments(int count)
		{
		}
	}
}
