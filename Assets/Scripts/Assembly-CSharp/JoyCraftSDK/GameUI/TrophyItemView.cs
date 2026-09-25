using JoyCraftSDK.TrophyRoom;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class TrophyItemView : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private TextMeshProUGUI costText;

		[Tooltip("Optional — để trống nếu prefab chưa dùng.")]
		[SerializeField]
		private GameObject ownedOverlay;

		[Tooltip("Optional — để trống nếu prefab chưa dùng.")]
		[SerializeField]
		private GameObject lockedOverlay;

		[Tooltip("Optional — để trống nếu prefab chưa dùng.")]
		[SerializeField]
		private GameObject nextHighlight;

		public void Bind(TrophyItemDef def, bool isOwned, bool isNext)
		{
		}
	}
}
