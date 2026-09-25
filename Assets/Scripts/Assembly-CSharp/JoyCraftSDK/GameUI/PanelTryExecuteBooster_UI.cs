using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PanelTryExecuteBooster_UI : APanelTryExecuteBooster_UI
	{
		private BoosterType boosterType;

		public GameObject busPickerLabel;

		public GameObject colorPickerLabel;

		public GameObject shuffleLabel;

		public Button[] closeBtns;

		public GameObject BGFade_Plane;

		public GameObject BGFade_Passenger;

		public override BoosterType BoosterType
		{
			get
			{
				return BoosterType.None;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public override void Show()
		{
		}

		public void OnClickCloseBtn()
		{
		}

		public override void Hide()
		{
		}
	}
}
