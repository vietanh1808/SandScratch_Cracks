using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class LevelSwapController : ALevelSwapController
	{
		private const string Group_Refs = "References";

		private const int DefaultWinCoin = 40;

		[Tooltip("Component implement ILevelSwapView (LevelSpawner).")]
		[SerializeField]
		private LevelSpawner levelSwapView;

		[SerializeField]
		private ALevelRangeSwapConfig swapConfig;

		private bool _armed;

		private bool _swapping;

		private Sequence _seq;

		private LevelController Level => null;

		public override ALevelRangeSwapConfig SwapConfig => null;

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		public override bool TryHandleWin()
		{
			return false;
		}

		private void CompleteSwap(IReadOnlyList<SwapElement> incoming, ILevelSwapView view, LevelController level)
		{
		}

		private float ComputeOffscreenDistance()
		{
			return 0f;
		}

		private void RaiseWinReward()
		{
		}

		private int ResolveWinCoin()
		{
			return 0;
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
