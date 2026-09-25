using JoyCraftSDK.ToolBox;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class TxtLevelTime : JMonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI levelTimeText;

		[SerializeField]
		private Image levelTimeImage;

		[SerializeField]
		private Sprite normalSr;

		[SerializeField]
		private Sprite hardSr;

		[SerializeField]
		private Sprite veryHardSr;

		private bool _listening;

		private ReleaseDifficulty currentLevelDiff;

		private void Start()
		{
		}

		private void UpdateImg()
		{
		}

		private void UpdateTxt()
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void OnTimerUpdate(ATimer timer)
		{
		}

		private void OnTimerFinished(ATimer timer)
		{
		}

		private void ListenToTimerUpdate()
		{
		}

		private void StopListenToTimerUpdate()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
