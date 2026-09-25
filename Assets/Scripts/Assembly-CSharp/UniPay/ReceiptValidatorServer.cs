using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UniPay.SimpleJSON;
using UnityEngine;
using UnityEngine.Purchasing.Security;

namespace UniPay
{
	public class ReceiptValidatorServer : ReceiptValidator
	{
		[CompilerGenerated]
		private static Action m_inventoryCallback;

		[CompilerGenerated]
		private static Action<string, JSONNode> m_purchaseCallback;

		[Header("General Data")]
		public string appID;

		public string userID;

		[Header("User Inventory is not supported on the Free plan.", order = 0)]
		[Header("Please leave it on 'Disabled' if you didn't upgrade.", order = 1)]
		public InventoryRequestType inventoryRequestType;

		private const string validationEndpoint = "https://api.iapguard.com/v1/receipt/";

		private const string userEndpoint = "https://api.iapguard.com/v1/user/";

		private Dictionary<string, PurchaseResponse> inventory;

		private Dictionary<string, ReceiptRequest> activeRequests;

		private CrossPlatformValidator localValidator;

		private const string lastInventoryTimestampKey = "fbrv_inventory_timestamp";

		private float lastInventoryTime;

		private bool inventoryRequestActive;

		private int inventoryDelay;

		public static event Action inventoryCallback
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

		public static event Action<string, JSONNode> purchaseCallback
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

		private void Start()
		{
		}
	}
}
