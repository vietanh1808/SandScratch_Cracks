using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JoyCraftSDK.GameUI
{
	public class PopupBattlePassInfo : JUIPanel, IPointerClickHandler, IEventSystemHandler
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private CanvasGroup dimGroup;

		[SerializeField]
		private CanvasGroup[] revealItems;

		[SerializeField]
		private CanvasGroup coRevealWithLastItem;

		[SerializeField]
		private CanvasGroup tapToContinueGroup;

		[SerializeField]
		private float dimFadeDuration;

		[SerializeField]
		private float itemFadeDuration;

		[SerializeField]
		private float itemStagger;

		[SerializeField]
		private float itemPopScale;

		[SerializeField]
		private float tapPulseScale;

		[SerializeField]
		private float tapPulseDuration;

		private Sequence _revealSequence;

		private Tween _tapPulse;

		private bool _isRevealed;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public override void OnAppear()
		{
		}

		public override void OnDisappear()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void PlayReveal()
		{
		}

		private void AppendItemReveal(Sequence seq, CanvasGroup item)
		{
		}

		private void AppendItemReveal(Sequence seq, CanvasGroup item, bool suppressInterval)
		{
		}

		private void JoinItemReveal(Sequence seq, CanvasGroup item)
		{
		}

		private void OnRevealComplete()
		{
		}

		private void SkipToEnd()
		{
		}

		private void StartTapPulse()
		{
		}

		private void SetItemHidden(CanvasGroup item)
		{
		}

		private void SetItemShown(CanvasGroup item)
		{
		}

		private void KillTweens()
		{
		}
	}
}
