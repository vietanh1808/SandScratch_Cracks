using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.AdminTest
{
	public class CellViewCoinOption : AAdminTestCellView
	{
		[SerializeField]
		private GridLayoutGroup grid;

		[SerializeField]
		private float headerAndPadding;

		public override float CellSize => 0f;

		private int CountActiveButtons()
		{
			return 0;
		}
	}
}
