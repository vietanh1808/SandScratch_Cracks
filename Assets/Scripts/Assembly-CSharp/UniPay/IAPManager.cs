using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;

namespace UniPay
{
	public class IAPManager : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialize_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public IAPManager _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRestoreTransactions_003Ed__69 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Orders orders;

			public bool withValidation;

			public IAPManager _003C_003E4__this;

			private IEnumerator<ConfirmedOrder> _003C_003E7__wrap1;

			private Order _003Corder_003E5__3;

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

		public IAPScriptableObject asset;

		public bool autoInitialize;

		public static bool isDebug;

		public static Dictionary<string, ShopItem2D> shopItems;

		[CompilerGenerated]
		private static Action m_initializeSucceededEvent;

		[CompilerGenerated]
		private static Action<string> m_initializeFailedEvent;

		[CompilerGenerated]
		private static Action<string> m_purchaseStartedEvent;

		[CompilerGenerated]
		private static Action<string> m_purchaseSucceededEvent;

		[CompilerGenerated]
		private static Action<string> m_purchaseFailedEvent;

		[CompilerGenerated]
		private static Action<string> m_consumeStartedEvent;

		[CompilerGenerated]
		private static Action<string> m_consumeSucceededEvent;

		[CompilerGenerated]
		private static Action<string> m_consumeFailedEvent;

		[CompilerGenerated]
		private static Action m_restoreTransactionsStartedEvent;

		[CompilerGenerated]
		private static Action<bool> m_restoreTransactionsFinishedEvent;

		[CompilerGenerated]
		private static Action m_receiptValidationInitializeEvent;

		[CompilerGenerated]
		private static Action<Order> m_receiptValidationPurchaseEvent;

		[CompilerGenerated]
		private static Action<IAPProduct> m_remotePurchaseVirtualEvent;

		[CompilerGenerated]
		private static Action<IAPProduct, int> m_remoteConsumePurchaseEvent;

		public static StoreController controller;

		private bool isInitialized;

		private ExponentialBackOffRetryPolicy retryPolicy;

		public static IAPManager Instance { get; private set; }

		public static bool Initialized => false;

		public static event Action initializeSucceededEvent
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

		public static event Action<string> initializeFailedEvent
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

		public static event Action<string> purchaseStartedEvent
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

		public static event Action<string> purchaseSucceededEvent
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

		public static event Action<string> purchaseFailedEvent
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

		public static event Action<string> consumeStartedEvent
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

		public static event Action<string> consumeSucceededEvent
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

		public static event Action<string> consumeFailedEvent
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

		public static event Action restoreTransactionsStartedEvent
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

		public static event Action<bool> restoreTransactionsFinishedEvent
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

		public static event Action receiptValidationInitializeEvent
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

		public static event Action<Order> receiptValidationPurchaseEvent
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

		internal static event Action<IAPProduct> remotePurchaseVirtualEvent
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

		internal static event Action<IAPProduct, int> remoteConsumePurchaseEvent
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

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__56))]
		public void Initialize()
		{
		}

		public void OnSceneWasLoaded(Scene scene, LoadSceneMode m)
		{
		}

		private void FetchProducts()
		{
		}

		private void OnProductsFetched(List<Product> products)
		{
		}

		private void OnPurchasesFetched(Orders orders)
		{
		}

		private void OverwriteWithFetch(List<Product> products)
		{
		}

		public static void Purchase(string productID)
		{
		}

		public static void Consume(string productID, int amount = 1)
		{
		}

		private void OnPurchasePending(PendingOrder order)
		{
		}

		private void OnPurchaseConfirmed(Order order)
		{
		}

		public void CompletePurchase(string productID, bool withEvent = true)
		{
		}

		public void CompleteConsume(string productID, int amount)
		{
		}

		public static void RestoreTransactions()
		{
		}

		[AsyncStateMachine(typeof(_003CRestoreTransactions_003Ed__69))]
		private void RestoreTransactions(Orders orders, bool withValidation = false)
		{
		}

		private void OnTransactionsRestored(bool success, string error)
		{
		}

		private void OnInitialized()
		{
		}

		private void OnInitializeFailed(StoreConnectionFailureDescription error)
		{
		}

		private void OnProductsFetchFailed(ProductFetchFailed error)
		{
		}

		private void OnPurchasesFetchFailed(PurchasesFetchFailureDescription error)
		{
		}

		private void OnPurchaseFailed(FailedOrder order)
		{
		}

		private void OnPurchaseDeferred(DeferredOrder order)
		{
		}

		public static void OnPurchaseFailed(string productId, string error)
		{
		}

		public static void OnConsumeFailed(string error)
		{
		}

		public void RefreshShopItemAll()
		{
		}

		public void RefreshShopItemGroup(string groupName)
		{
		}

		public void RefreshShopItem(string productID)
		{
		}

		public static Product GetFirstProductInOrder(Order order)
		{
			return null;
		}

		public static List<string> GetAllUpgrades(string productId)
		{
			return null;
		}

		public static string GetCurrentUpgrade(string productId)
		{
			return null;
		}

		public static string GetNextUpgrade(string productId)
		{
			return null;
		}

		public static string GetProductGlobalIdentifier(string storeId)
		{
			return null;
		}

		public static ProductDefinition[] GetProductDefinitions()
		{
			return null;
		}

		public static bool HasPendingPurchases()
		{
			return false;
		}

		public static bool HasProductRewards(string productId)
		{
			return false;
		}

		public static List<KeyValuePairStringInt> GetProductRewards(string productId)
		{
			return null;
		}

		public static string[] GetAllIDs()
		{
			return null;
		}

		public static string[] GetRealMoneyIDs()
		{
			return null;
		}

		public static string[] GetStoreIDs()
		{
			return null;
		}

		public static IAPProduct GetIAPProduct(string productID)
		{
			return null;
		}

		public static ShopItem2D GetShopItem(string productID)
		{
			return null;
		}

		public static string GetProductCategoryName(string productID)
		{
			return null;
		}
	}
}
