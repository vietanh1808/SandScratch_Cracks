using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class TrophySlotView : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		[Tooltip("Phải khớp TrophyItemDef.id trong config — TrophyRoomView bind theo id này, không theo index.")]
		[SerializeField]
		private int itemId;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private GameObject ownedPlaceholder;

		[SerializeField]
		private GameObject emptyPlaceholder;

		private RectTransform _rectTransform;

		public int ItemId => 0;

		public Sprite IconSprite => null;

		public Transform LandingTransform => null;

		public void Setup(int newItemId, Sprite sprite, Vector2 position, Vector2 size)
		{
		}

		public void RevealNow()
		{
		}

		public void Bind(bool isOwned)
		{
		}

		public void Clear()
		{
		}

		private RectTransform CachedRectTransform()
		{
			return null;
		}
	}
}
