using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.UI;

namespace JoyCraftSDK.Utilities
{
	public static class GUIUtils
	{
		[CompilerGenerated]
		private sealed class _003CProgressAnim_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float oldValue;

			public float newValue;

			public Image bar;

			private float _003CcurrentValue_003E5__2;

			private float _003Cspeed_003E5__3;

			private float _003CcurrentProgress_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CProgressAnim_003Ed__1(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CTextAnim_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public long oldValue;

			public long newValue;

			public TMP_Text label;

			private long _003CcurrentValue_003E5__2;

			private float _003Cspeed_003E5__3;

			private float _003CcurrentProgress_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTextAnim_003Ed__0(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[IteratorStateMachine(typeof(_003CTextAnim_003Ed__0))]
		public static IEnumerator TextAnim(TMP_Text label, long oldValue, long newValue)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CProgressAnim_003Ed__1))]
		public static IEnumerator ProgressAnim(Image bar, float oldValue, float newValue)
		{
			return null;
		}
	}
}
