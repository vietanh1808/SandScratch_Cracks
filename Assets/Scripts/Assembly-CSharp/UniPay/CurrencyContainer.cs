using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UniPay
{
	public class CurrencyContainer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountTo_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CurrencyContainer _003C_003E4__this;

			public int target;

			private int _003Cstart_003E5__2;

			private float _003Ctimer_003E5__3;

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
			public _003CCountTo_003Ed__10(int _003C_003E1__state)
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

		public TMP_Text label;

		public Image image;

		[HideInInspector]
		[SerializeReference]
		public IAPCurrency currency;

		public float duration;

		private int curValue;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateValue()
		{
		}

		private void UpdateValue(string s)
		{
		}

		[IteratorStateMachine(typeof(_003CCountTo_003Ed__10))]
		private IEnumerator CountTo(int target)
		{
			return null;
		}
	}
}
