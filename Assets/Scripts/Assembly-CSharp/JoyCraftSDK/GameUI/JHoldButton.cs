using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public class JHoldButton : JMonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[SerializeField]
		private UnityEvent onPressed;

		[SerializeField]
		private UnityEvent onReleased;

		private bool _isHeld;

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
