using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class HeartView : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private TMP_Text heartCountText;

		[SerializeField]
		private TMP_Text countdownText;

		[SerializeField]
		private GameObject moreHeartBtn;

		[SerializeField]
		private Image heartIcon;

		[SerializeField]
		private float tickIntervalSeconds;

		[SerializeField]
		private Sprite normalHeartSprite;

		[SerializeField]
		private Sprite infiniteHeartSprite;

		[SerializeField]
		private Button btn;

		private float timer;

		private int heartCount;

		private int maxHeart;

		private bool showCountdown => false;

		private void Start()
		{
		}

		private void OnClickMe()
		{
		}

		protected override void OnEnable()
		{
		}

		private void TestAddLife(int count)
		{
		}

		private void Refresh()
		{
		}

		private void UpdateCountText()
		{
		}

		private void UpdateCountdownText(bool infiniteActive)
		{
		}

		private static string FormatTime(float seconds)
		{
			return null;
		}

		private void OnHeartChange(ref AEventManager.OnHeartChange eventData)
		{
		}

		private void OnInfiniteHeartChange(ref AEventManager.OnInfiniteHeartChange eventData)
		{
		}

		private void OnUpdate(ref AEventManager.OnUpdate eventData)
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
