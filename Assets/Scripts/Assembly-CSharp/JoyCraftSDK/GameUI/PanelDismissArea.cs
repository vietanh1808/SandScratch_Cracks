using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Graphic))]
	public class PanelDismissArea : JMonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[SerializeField]
		private AUIPanel _panel;

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
