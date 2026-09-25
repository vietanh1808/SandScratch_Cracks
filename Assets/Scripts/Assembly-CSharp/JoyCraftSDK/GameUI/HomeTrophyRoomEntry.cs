using JoyCraftSDK.TrophyRoom;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class HomeTrophyRoomEntry : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private GameObject trophyRoomIcon;

		[SerializeField]
		private GameObject affordableBadge;

		[SerializeField]
		private GameObject pendingBadge;

		[SerializeField]
		private GameObject newBadge;

		private ATrophyRoomManager _trophyRoomManager => null;

		protected override void OnEnable()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnStarChange(ref AEventManager.OnStarChange eventData)
		{
		}

		private void OnTrophyItemPurchased(ref AEventManager.OnTrophyItemPurchased eventData)
		{
		}

		private void OnTrophyRoomCompleted(ref AEventManager.OnTrophyRoomCompleted eventData)
		{
		}

		private void Refresh()
		{
		}

		private void RefreshBadges(bool iconVisible)
		{
		}

		private bool HasAffordableUnownedItem()
		{
			return false;
		}
	}
}
