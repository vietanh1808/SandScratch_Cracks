using System;
using JoyCraftSDK.Utilities;
using UnityEngine.EventSystems;

namespace JoyCraftSDK.GameUI
{
	public abstract class AButtonAnim : JMonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public virtual void ShowAnim(Action onComplete = null)
		{
		}

		public virtual void HideAnim(Action onComplete = null)
		{
		}

		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
