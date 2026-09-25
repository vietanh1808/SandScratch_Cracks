using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JTab : JMonoBehaviour
	{
		[SerializeField]
		private List<ATabBtn> tabButtons;

		[SerializeField]
		private List<ATabPage> tabPages;

		[SerializeField]
		private int defaultTabIndex;

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void SetupButtonClicks()
		{
		}

		private void OnTabClick(ATabBtn tabButton)
		{
		}
	}
}
