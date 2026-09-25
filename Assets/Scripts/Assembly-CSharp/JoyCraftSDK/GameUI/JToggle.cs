using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class JToggle : JMonoBehaviour
	{
		[SerializeField]
		private AToggleEvents toggle;

		protected abstract void OnToggleValueChanged(bool newValue);

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected void SetValueWithoutInvoke(bool newValue)
		{
		}
	}
}
