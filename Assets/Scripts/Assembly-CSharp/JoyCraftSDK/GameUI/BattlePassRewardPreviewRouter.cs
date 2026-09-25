using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BattlePassRewardPreviewRouter : JMonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Tooltip("Image phủ toàn màn của CHÍNH node này — code bật/tắt Raycast Target để bắt click nền.")]
		[SerializeField]
		private Image blockerImage;

		private BattlePassMilestoneView openedView;

		public void Toggle(BattlePassMilestoneView milestoneView)
		{
		}

		public void Close()
		{
		}

		public void CloseIf(BattlePassMilestoneView milestoneView)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		protected override void OnDisable()
		{
		}

		private void SetBlockerActive(bool isActive)
		{
		}
	}
}
