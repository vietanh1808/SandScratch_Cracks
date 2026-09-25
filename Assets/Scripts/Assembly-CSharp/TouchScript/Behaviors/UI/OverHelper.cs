using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TouchScript.Behaviors.UI
{
	[AddComponentMenu("TouchScript/Behaviors/OverHelper")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_UI_OverHelper.htm")]
	public class OverHelper : MonoBehaviour
	{
		[CompilerGenerated]
		private EventHandler m_Over;

		[CompilerGenerated]
		private EventHandler m_Out;

		private HashSet<int> pointers;

		public event EventHandler Over
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler Out
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void dispatchOver()
		{
		}

		private void dispatchOut()
		{
		}

		private void pointersAddedHandler(object sender, PointerEventArgs pointerEventArgs)
		{
		}

		private void pointersUpdatedHandler(object sender, PointerEventArgs pointerEventArgs)
		{
		}

		private void pointersReleasedHandler(object sender, PointerEventArgs pointerEventArgs)
		{
		}

		private void pointersRemovedHandler(object sender, PointerEventArgs pointerEventArgs)
		{
		}
	}
}
