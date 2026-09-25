using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Networking;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace UniPay
{
	internal class PayPalStore : Store
	{
		[Serializable]
		public class AccessToken
		{
			public string token;

			public long expirationTime;

			public AccessToken(string token, long time)
			{
			}

			public bool IsValid()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CApproveTransaction_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PayPalStore _003C_003E4__this;

			private IAPProduct _003Cproduct_003E5__2;

			private UnityWebRequest _003Cwww_003E5__3;

			private UnityWebRequest _003C_003E7__wrap3;

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
			public _003CApproveTransaction_003Ed__19(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnect_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PayPalStore _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetAccessToken_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PayPalStore _003C_003E4__this;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CGetAccessToken_003Ed__17(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPurchaseRequest_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PayPalStore _003C_003E4__this;

			public ICart cart;

			private Product _003CcurrentProduct_003E5__2;

			private UnityWebRequest _003Cwww_003E5__3;

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
			public _003CPurchaseRequest_003Ed__18(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public IAPManager iapManager;

		private PayPalStoreConfig config;

		private AccessToken accessToken;

		private string orderId;

		private ICart currentCart;

		public static PayPalStore instance { get; private set; }

		public PayPalStore(IAPManager iapManager)
		{
		}

		[AsyncStateMachine(typeof(_003CConnect_003Ed__10))]
		public override void Connect()
		{
		}

		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> definitions)
		{
		}

		public override void FetchPurchases()
		{
		}

		public override void CheckEntitlement(ProductDefinition product)
		{
		}

		public override void Purchase(ICart cart)
		{
		}

		public override void FinishTransaction(PendingOrder order)
		{
		}

		public void ConfirmPurchase()
		{
		}

		[IteratorStateMachine(typeof(_003CGetAccessToken_003Ed__17))]
		private IEnumerator GetAccessToken()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPurchaseRequest_003Ed__18))]
		private IEnumerator PurchaseRequest(ICart cart)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CApproveTransaction_003Ed__19))]
		private IEnumerator ApproveTransaction()
		{
			return null;
		}

		private string GetPostData(IAPProduct product)
		{
			return null;
		}

		private string GetPostDataOneTime(IAPProduct product)
		{
			return null;
		}

		private string GetPostDataSubscription(IAPProduct product)
		{
			return null;
		}

		private string GetUrl(string api, ProductType type = ProductType.NonConsumable)
		{
			return null;
		}

		internal ConnectionState GetStoreConnectionState()
		{
			return ConnectionState.Disconnected;
		}
	}
}
